using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ArisenStudio;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArisenStudio.Extensions
{
    public class GitHubCacheUpdater
    {
        private readonly HttpClient _httpClient;
        private readonly string _cacheShaFilePath;

        private const string Owner = "ohhsodead";
        private const string Repo = "arisen-studio-database";

        // Dictionary to store file paths and cached commit SHAs
        private readonly Dictionary<string, string> _filesToCache = new Dictionary<string, string>
    {
        { "categories.json", null },
        { "PS3/gameMods-new.json", null },
        { "PS3/homebrew-new.json", null }
        // Add other files as needed
    };

        public GitHubCacheUpdater()
        {
            _httpClient = new HttpClient();
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string cacheDirectory = Path.Combine(appDataPath, "Arisen Studio", "Cache");
            Directory.CreateDirectory(cacheDirectory);
            _cacheShaFilePath = Path.Combine(cacheDirectory, "cache_sha.json");
        }

        public async Task<string> GetLatestCommitShaForFileAsync(string filePath)
        {
            var url = $"https://api.github.com/repos/{Owner}/{Repo}/commits?path={filePath}&page=1&per_page=1";
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("C# App");

            var response = await _httpClient.GetStringAsync(url);
            var commits = JArray.Parse(response);

            if (commits.Count == 0)
            {
                throw new Exception("No commits found for the specified file.");
            }

            var latestCommit = commits[0];
            string commitSha = latestCommit["sha"].ToString();
            return commitSha;
        }

        public async Task<(string Content, string NewCommitSha)?> UpdateCacheIfNeededAsync(string filePath, string cachedCommitSha)
        {
            var latestCommitSha = await GetLatestCommitShaForFileAsync(filePath);

            if (latestCommitSha != cachedCommitSha)
            {
                var fileUrl = $"https://raw.githubusercontent.com/{Owner}/{Repo}/main/{filePath}";
                var content = await _httpClient.GetStringAsync(fileUrl);
                return (content, latestCommitSha);
            }

            return null; // Cache is still valid
        }

        private Dictionary<string, string> LoadCachedShas()
        {
            if (File.Exists(_cacheShaFilePath))
            {
                var json = File.ReadAllText(_cacheShaFilePath);
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
            return new Dictionary<string, string>();
        }

        private void SaveCachedShas(Dictionary<string, string> cachedShas)
        {
            var json = JsonConvert.SerializeObject(cachedShas, Formatting.Indented);
            File.WriteAllText(_cacheShaFilePath, json);
        }

        public async Task CheckAndUpdateCacheAsync()
        {
            var cachedShas = LoadCachedShas();

            foreach (var filePath in _filesToCache.Keys.ToList())
            {
                _filesToCache.TryGetValue(filePath, out var cachedCommitSha);

                var result = await UpdateCacheIfNeededAsync(filePath, cachedCommitSha);

                if (result != null)
                {
                    string newContent = result.Value.Content;
                    string newCommitSha = result.Value.NewCommitSha;

                    SaveToLocalCache(filePath, newContent);
                    _filesToCache[filePath] = newCommitSha;
                    SaveCachedShas(_filesToCache);
                }
                else
                {
                    Program.Log.Info($"{filePath} cache is still up-to-date.");
                }
            }
        }

        private void SaveToLocalCache(string filePath, string content)
        {
            string localCachePath = Path.Combine("local_cache", filePath);
            Directory.CreateDirectory(Path.GetDirectoryName(localCachePath));
            File.WriteAllText(localCachePath, content);
        }
    }
}
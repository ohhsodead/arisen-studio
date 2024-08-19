using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ArisenStudio.Extensions
{
    public class SimpleCache<T>
    {
        private readonly Dictionary<string, CacheItem> _cache = new();
        private readonly string _cacheFilePath;
        private readonly string _cacheShaFilePath;

        public SimpleCache(string cacheFileName)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directoryPath = Path.Combine(appDataPath, "Arisen Studio", "Cache");

            Directory.CreateDirectory(directoryPath);

            _cacheFilePath = Path.Combine(directoryPath, cacheFileName);
            _cacheShaFilePath = Path.Combine(directoryPath, $"{cacheFileName}.sha");

            LoadCacheFromFile();
        }

        public void Add(string key, T value, string sha)
        {
            var cacheItem = new CacheItem
            {
                Value = value,
                Sha = sha
            };
            _cache[key] = cacheItem;
            SaveCacheToFile();
            SaveShaToFile();
        }

        public bool TryGetValue(string key, out T value, out string sha)
        {
            if (_cache.TryGetValue(key, out var cacheItem))
            {
                value = cacheItem.Value;
                sha = cacheItem.Sha;
                return true;
            }
            value = default;
            sha = null;
            return false;
        }

        private void SaveCacheToFile()
        {
            var json = JsonConvert.SerializeObject(_cache);
            File.WriteAllText(_cacheFilePath, json);
        }

        private void SaveShaToFile()
        {
            var shaCache = new Dictionary<string, string>();
            foreach (var item in _cache)
            {
                shaCache[item.Key] = item.Value.Sha;
            }
            var json = JsonConvert.SerializeObject(shaCache);
            File.WriteAllText(_cacheShaFilePath, json);
        }

        private void LoadCacheFromFile()
        {
            if (File.Exists(_cacheFilePath))
            {
                var json = File.ReadAllText(_cacheFilePath);
                var loadedCache = JsonConvert.DeserializeObject<Dictionary<string, CacheItem>>(json);

                if (loadedCache != null)
                {
                    foreach (var item in loadedCache)
                    {
                        _cache[item.Key] = item.Value;
                    }
                }
            }
            LoadShaFromFile();
        }

        private void LoadShaFromFile()
        {
            if (File.Exists(_cacheShaFilePath))
            {
                var json = File.ReadAllText(_cacheShaFilePath);
                var shaCache = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                if (shaCache != null)
                {
                    foreach (var item in shaCache)
                    {
                        if (_cache.TryGetValue(item.Key, out var cacheItem))
                        {
                            cacheItem.Sha = item.Value;
                            _cache[item.Key] = cacheItem;
                        }
                    }
                }
            }
        }

        private class CacheItem
        {
            public T Value { get; set; }
            public string Sha { get; set; }
        }
    }
}
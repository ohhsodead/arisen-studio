using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class SimpleCache<T>
{
    private readonly Dictionary<string, CacheItem> _cache = [];
    private readonly TimeSpan _expirationTime;
    private readonly string _cacheFilePath;

    public SimpleCache(TimeSpan expirationTime, string cacheFileName)
    {
        _expirationTime = expirationTime;

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string directoryPath = Path.Combine(appDataPath, "Arisen Studio", "Cache");

        Directory.CreateDirectory(directoryPath);

        _cacheFilePath = Path.Combine(directoryPath, cacheFileName);

        LoadCacheFromFile();
    }

    public void Add(string key, T value)
    {
        var cacheItem = new CacheItem
        {
            Value = value,
            Expiration = DateTime.Now.Add(_expirationTime)
        };
        _cache[key] = cacheItem;
        SaveCacheToFile();
    }

    public bool TryGetValue(string key, out T value)
    {
        if (_cache.TryGetValue(key, out var cacheItem))
        {
            if (cacheItem.Expiration > DateTime.Now)
            {
                value = cacheItem.Value;
                return true;
            }
            else
            {
                _cache.Remove(key);
                SaveCacheToFile();
            }
        }
        value = default;
        return false;
    }

    private void SaveCacheToFile()
    {
        var json = JsonConvert.SerializeObject(_cache);
        File.WriteAllText(_cacheFilePath, json);
    }

    private void LoadCacheFromFile()
    {
//#if !DEBUG
        if (File.Exists(_cacheFilePath))
        {
            var json = File.ReadAllText(_cacheFilePath);
            var loadedCache = JsonConvert.DeserializeObject<Dictionary<string, CacheItem>>(json);

            if (loadedCache != null)
            {
                foreach (var item in loadedCache)
                {
                    if (item.Value.Expiration > DateTime.Now)
                    {
                        _cache[item.Key] = item.Value;
                    }
                }
            }
        }
//#endif
    }

    private class CacheItem
    {
        public T Value { get; set; }

        public DateTime Expiration { get; set; }
    }
}

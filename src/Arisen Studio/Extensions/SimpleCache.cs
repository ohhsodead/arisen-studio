using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ArisenStudio.Extensions
{
    public class SimpleCache<T>
    {
        private readonly string _cacheFilePath;
        private CacheContainer<T> _cacheContainer;

        public SimpleCache(string cacheFileName)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directoryPath = Path.Combine(appDataPath, "Arisen Studio", "Cache");

            Directory.CreateDirectory(directoryPath);

            // Ensure the directory exists
            var directory = Path.GetDirectoryName(directoryPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            _cacheFilePath = Path.Combine(directoryPath, cacheFileName);
            LoadCache();
        }

        // Try to get the cached value and its metadata
        public bool TryGetValue(string key, out T value, out CacheMetadata metadata)
        {
            if (_cacheContainer.Cache.TryGetValue(key, out var cacheEntry))
            {
                value = cacheEntry.Data;
                metadata = cacheEntry.Metadata;
                return true;
            }

            value = default;
            metadata = null;
            return false;
        }

        // Add or update the cache with new data and metadata
        public void Add(string key, T data, CacheMetadata metadata)
        {
            _cacheContainer.Cache[key] = new CacheEntry<T> { Data = data, Metadata = metadata };
            SaveCache();
        }

        // Load the cache from disk
        private void LoadCache()
        {
            if (File.Exists(_cacheFilePath))
            {
                var json = File.ReadAllText(_cacheFilePath);
                _cacheContainer = JsonConvert.DeserializeObject<CacheContainer<T>>(json) ?? new CacheContainer<T>();
            }
            else
            {
                _cacheContainer = new CacheContainer<T>();
            }
        }

        // Save the cache to disk
        private void SaveCache()
        {
            var json = JsonConvert.SerializeObject(_cacheContainer, Formatting.Indented);
            File.WriteAllText(_cacheFilePath, json);
        }

        // A container for the cache data and metadata
        private class CacheContainer<U>
        {
            public Dictionary<string, CacheEntry<U>> Cache { get; set; } = [];
        }

        // A class representing a single cache entry with data and metadata
        private class CacheEntry<U>
        {
            public U Data { get; set; }

            public CacheMetadata Metadata { get; set; }
        }
    }

    // Metadata class to store ETag and Last-Modified headers
    public class CacheMetadata
    {
        public string ETag { get; set; }

        public DateTimeOffset? LastModified { get; set; }
    }
}
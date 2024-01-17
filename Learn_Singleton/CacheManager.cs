

namespace Learn_Singleton;

public sealed class CacheManager
{
    private static readonly Lazy<CacheManager> _lazyInstance = new Lazy<CacheManager>(() => new CacheManager());
    public static CacheManager Instance => _lazyInstance.Value;

    private CacheManager()
    {
        cacheStore = new();
    }


    private readonly Dictionary<string, object> cacheStore;

    public void AddToCache(string key, object value)
    {
        if (!cacheStore.ContainsKey(key))
        {
            cacheStore.TryAdd(key, value);
        }
    }
    public void RemoveToCache(string key)
    {
        if (!cacheStore.ContainsKey(key))
        {
            cacheStore.Remove(key);
        }
    }

    public object GetFromCache(string key)
    {
        cacheStore.TryGetValue(key,out var value);
        return value;
    }
  
}

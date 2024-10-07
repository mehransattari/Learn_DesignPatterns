

namespace Learn_Singleton;

public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> lazyInstance = 
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    public static ConfigurationManager Instance = lazyInstance.Value;
    private ConfigurationManager()
    {
        LoadConfigurations();
    }

    private Dictionary<string, string> configurations;

    private void LoadConfigurations()
    {
        configurations = new Dictionary<string, string>()
        {
            {"TestApi1","https://test1.com"},
            {"TestApi2","https://test2.com"},
            {"TestApi3","https://test3.com"}
        };
    }

    public string GetConfigurations(string key)
    {        
        configurations.TryGetValue(key,out var value);
        return value;
    }
}

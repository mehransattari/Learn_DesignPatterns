
using Learn_Singleton;

Singleton.Instance.LogMessage("singleton in c#");

Console.WriteLine("***********************");

string apiEndpoint = ConfigurationManager.Instance.GetConfigurations("TestApi1");
Console.WriteLine(apiEndpoint);

Console.WriteLine("***********************");

//cahce

var cahce = CacheManager.Instance;

cahce.AddToCache("Name","Mehran Sattary");

var result = cahce.GetFromCache("Name");

Console.WriteLine("result : " +result);

cahce.RemoveToCache("Name");

var resultAfterRemove = cahce.GetFromCache("Name");

Console.WriteLine("resultAfterRemove : "+resultAfterRemove);

//cahce2

var cahce2 = CacheManager.Instance;

cahce2.AddToCache("Name2", "Andress Sattary");

var result2 = cahce2.GetFromCache("Name2");

Console.WriteLine("result2 : " + result2);


Console.WriteLine("***********************");

SettingsManager settingsManager = SettingsManager.Instance;

settingsManager.AppTitle = "My Updated App Title";
settingsManager.MaxConnections = 20;

SettingsManager anotherSettingsManager = SettingsManager.Instance;


anotherSettingsManager.AppTitle = "My Updated App Title 1";
anotherSettingsManager.MaxConnections = 40;

// چون الگوی Singleton استفاده شده است، دو نمونه باید یکسان باشند
Console.WriteLine(settingsManager.AppTitle); // خروجی: My Updated App Title
Console.WriteLine(settingsManager.MaxConnections); // خروجی: 20

Console.WriteLine(anotherSettingsManager.AppTitle); // خروجی: My Updated App Title
Console.WriteLine(anotherSettingsManager.MaxConnections); // خروجی: 20
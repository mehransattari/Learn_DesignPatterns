

namespace Learn_Singleton;

public class SettingsManager
{
   // private static readonly SettingsManager instance = new SettingsManager();
   // تازمانی که  نیاز نداریم از این نمونه ایجاد نمیکنه ومنابع را بیخودی اشغال نمیکنه
    private static readonly Lazy<SettingsManager> instance = new Lazy<SettingsManager>(()=>new SettingsManager());

    private string appTitle;
    private int maxConnections;
    private SettingsManager()
    {
        // مقادیر اولیه تنظیمات را در اینجا اختیاری می‌توانید اضافه کنید.
        appTitle = "MyApp";
        maxConnections = 10;
    }

    public static SettingsManager Instance => instance.Value;
    //public static SettingsManager Instance
    //{
    //    get
    //    {
    //        return instance;
    //    }
    //}

    public string AppTitle
    {
        get { return appTitle; }
        set { appTitle = value; }
    }

    public int MaxConnections
    {
        get { return maxConnections; }
        set
        {
            if (value > 0)
                maxConnections = value;
            else
                Console.WriteLine("تعداد حداکثر اتصالات باید بزرگتر از صفر باشد.");
        }
    }
}

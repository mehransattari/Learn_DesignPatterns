/* توضیحات
 فرض کن می‌خوای یه سیستم مدیریت سهام بسازی
که وقتی قیمت یک سهم تغییر می‌کنه،

چندین بخش از برنامه باید آپدیت بشن. مثلاً

***بخش نمایش قیمت سهم***
باید قیمت جدید رو نشون بده

***بخش ارسال ایمیل به کاربر***
 باید به کاربر ایمیل بزنه که قیمت سهم تغییر کرده

***بخش ثبت تاریخچه قیمت‌ها***
باید قیمت جدید رو توی پایگاه داده ذخیره کنه

در اینجا می‌تونیم از الگوی آبزرور استفاده کنیم
تا وقتی قیمت سهم تغییر کرد، 
همه این بخش‌ها بدون اینکه باهم در ارتباط مستقیم باشن، مطلع بشن

 */

// ساختن سهم جدید

// ایجاد ناظرها

// اضافه کردن ناظرها به سهم

// تغییر قیمت سهم
/// <summary>
/// سهم 
/// </summary>
public class Stock
{
    private List<IObserver> observers = new List<IObserver>();
    private string symbol;
    private double price;

    public Stock(string symbol, double price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    // تغییر قیمت و خبر دادن به همه ناظرها
    public void SetPrice(double newPrice)
    {
        price = newPrice;
        NotifyObservers();
    }

    // خبر دادن به همه ناظرها
    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(symbol, price);
        }
    }
}

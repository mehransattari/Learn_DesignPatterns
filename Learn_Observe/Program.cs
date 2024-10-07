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
var appleStock = new Stock("AAPL", 150.00);

// ایجاد ناظرها
var priceDisplay = new PriceDisplay();
var emailNotifier = new EmailNotifier();
var priceHistory = new PriceHistory();

// اضافه کردن ناظرها به سهم
appleStock.AddObserver(priceDisplay);
appleStock.AddObserver(emailNotifier);
appleStock.AddObserver(priceHistory);

// تغییر قیمت سهم
appleStock.SetPrice(155.00);  // همه ناظرها از این تغییر باخبر می‌شن
appleStock.SetPrice(160.00);

/*
 زمانی که کاربر در سیستم ثبت نام میکند توسط کلاس نوتیفیکیشن کاربری ،
پیغام هایی اتومات به ادمین وکاربر ویا هر کس دیگری که در کنترلر کاربر به این کلاس نوتیفیکیشن اضافه کرده ایم میرود.
 
 */


using Learn_Observe;

 ISubject _userNotifier = new UserNotifier();


// Attach observers
_userNotifier.Attach(new WelcomeEmailObserver());

_userNotifier.Attach(new AdminNotificationObserver());

_userNotifier.Notify(new User() { FirstName="Mehran",LastName="Sattary",Email="m@gmail.com"});

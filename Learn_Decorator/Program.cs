/*
 فرض کن یک کافی‌شاپ داری و می‌خوای انواع نوشیدنی‌ها رو سرو کنی.
هر نوشیدنی می‌تونه اضافات مختلفی مثل شیر، شکر یا خامه داشته باشه.
به جای اینکه برای هر ترکیب ممکن یک کلاس جدید بسازی، 
از الگوی دکوریتور استفاده می‌کنی.
 */

var plainCoffee = new Coffee();
Console.WriteLine($"{plainCoffee.GetDescription()} : ${plainCoffee.GetCost()}");

var milkCoffee = new MilkDecorator(plainCoffee);
Console.WriteLine($"{milkCoffee.GetDescription()} : ${milkCoffee.GetCost()}");

var sugarMilkCoffee = new SugarDecorator(milkCoffee);
Console.WriteLine($"{sugarMilkCoffee.GetDescription()} : ${sugarMilkCoffee.GetCost()}");

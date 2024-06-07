/*
  Prototype 
  الگوهای طراحی ساختاری 
Prototype الگوی طراحی ای است که اشیاء را مجبور می کند تا در زمان ساخت، کپی یا شبیه سازی شوند.
آیا کپی شی هم مهم است؟
جواب ساده است. زمانی که اشیاء زیادی برای کار کردن نیاز باشد و ساخت آنها بسیار هزینه بر باشد، کپی کردن آنها می تواند به بهبود کارایی کمک کند.
از آنجا که بحث به کپی کردن کشیده شد، اجازه دهید کمی راجع به Shallow Copy و Deep Copy نیز صحبت کنیم.


Shallow Copy
همانطور که از نام آن مشخص است، این نوع کپی به صورت جزئی (Partial) و یا ناقص عمل میکند و هر refrence type ای از شی منبع، کپی نمی شود و همچنان، به همان محل از حافظه اشاره می کند.
در .NET با استفاده از متد MemberwiseClone این کار انجام می شود.


Deep Copy
در این نوع کپی نیز، همانطور که از نام آن مشخص است، یک کپی واقعی از تمام اعضاء شی منبع، حتی Refrence typeها، تهیه می شود. برای Refrence type ها، یک محل جدید از حافظه در Heap، اختصاص داده می شود تا کپی به درستی اجرا شود.
برای اجرای Deep Copy باید خودمان کدنویسی کنیم.

 */


Console.Title = "Prototype pattern demo";

FourWheelar car = new FourWheelar();
car.VehicleType = "Car";
car.Brand = "Maruti";
car.Model = "Swift";
car.MoreInfo.Cost = "6.5 Lakhs INR";
car.MoreInfo.Ratings = 2;

FourWheelar truck = car.ShallowCopy() as FourWheelar;
truck.VehicleType = "Truck";
truck.Brand = "Tata";
truck.Model = "ACE";
truck.MoreInfo.Cost = "4.5 Lakhs INR";
truck.MoreInfo.Ratings = 3;

Console.WriteLine("******************************Shallow Copy******************************");
Console.WriteLine("Origional Object:");
car.ShowDetails();
Console.WriteLine();
Console.WriteLine("Shallow Cloned Object:");
truck.ShowDetails();

Console.WriteLine("******************************Deep Copy******************************");

Console.Title = "Prototype pattern demo";

FourWheelar car1 = new FourWheelar();
car1.VehicleType = "Car";
car1.Brand = "Maruti";
car1.Model = "Swift";
car1.MoreInfo.Cost = "6.5 Lakhs INR";
car1.MoreInfo.Ratings = 2;

FourWheelar truck1 = car.ShallowCopy() as FourWheelar;
truck1.VehicleType = "Truck";
truck1.Brand = "Tata";
truck1.Model = "ACE";
truck1.MoreInfo.Cost = "4.5 Lakhs INR";
truck1.MoreInfo.Ratings = 3;

Console.WriteLine("Origional Object:");
car1.ShowDetails();
Console.WriteLine();
Console.WriteLine("Deep Cloned Object:");
truck1.ShowDetails();

internal abstract class Vehicle
{
    internal string VehicleType { get; set; }
    internal string Brand { get; set; }
    internal string Model { get; set; }

    internal ExtraInformation MoreInfo = new ExtraInformation();

    internal abstract void ShowDetails();
    internal abstract Vehicle ShallowCopy();
    internal abstract Vehicle DeepCopy();
}

class ExtraInformation
{
    internal string Cost { get; set; }
    internal int Ratings { get; set; }
}

internal class FourWheelar : Vehicle, ICloneable
{
    internal override Vehicle ShallowCopy()
    {
        return this.MemberwiseClone() as Vehicle;
    }

    internal override Vehicle DeepCopy()
    {
        Vehicle vehicle = this.MemberwiseClone() as Vehicle;
        vehicle.MoreInfo = new ExtraInformation();
        vehicle.MoreInfo.Cost = this.MoreInfo.Cost;
        vehicle.MoreInfo.Ratings = this.MoreInfo.Ratings;
        return vehicle;
    }

    internal override void ShowDetails()
    {
        Console.WriteLine(string.Format("Vehicle Type: {0} \tBrand: {1} \tModel: {2} \tCost: {3} \tRatings: {4}", this.VehicleType, this.Brand, this.Model, this.MoreInfo.Cost, this.MoreInfo.Ratings));
    }

    public object Clone()
    {
        return DeepCopy();
    }
}
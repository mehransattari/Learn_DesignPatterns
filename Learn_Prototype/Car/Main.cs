
using System.Diagnostics;
using System;
namespace Learn_Prototype.Car;

public class Main
{
    public void Run()
    {
        Console.Title = "Prototype pattern demo";

        Console.WriteLine("******************************Shallow Copy******************************");

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

        FourWheelar truck1 = car1.Clone() as FourWheelar;
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
    }

}

namespace Zadanie4;

internal abstract class Zadanie4
{
    private static void Main()
    {
        Vehicle car = new Car();
        car.Brand = "Toyota";
        car.Model = "Corolla";
        car.Year = 2022;
        car.Start();
        car.Stop();

        Vehicle motorcycle = new Motorcycle();
        motorcycle.Brand = "Honda";
        motorcycle.Model = "CBR500R";
        motorcycle.Year = 2021;
        motorcycle.Start();
        motorcycle.Stop();

        Vehicle truck = new Truck();
        truck.Brand = "Volvo";
        truck.Model = "FH16";
        truck.Year = 2019;
        truck.Start();
        truck.Stop();
    }
}




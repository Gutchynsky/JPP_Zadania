namespace Zadanie4;

internal abstract class Vehicle
{
    public string Brand { get; set; } = "Unknown";
    public string Model { get; set; } = "Unknown";
    private string VehicleType => GetType().Name;
    public string VehicleSize { get; set; } = "Unknown";
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine($"{VehicleType} {Brand} {Model} engine started.");
    }

    public void Stop()
    {
        Console.WriteLine($"{VehicleType} {Brand} {Model} engine stopped.");
    }
}
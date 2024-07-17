using System;
 
namespace VehicleRentalManagementSystem
{

public class Car : Vehicle
{
    // Car-specific properties
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // Constructor
    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    // Implementation of the abstract method
    public override void DisplayDetails()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: {0}", Model);
        Console.WriteLine("Manufacturer: {0}", Manufacturer);
        Console.WriteLine("Year: {0}", Year);
        Console.WriteLine($"Rental Price: {RentalPrice}");
        Console.WriteLine("Seats: {0}", Seats);
        Console.WriteLine("Engine Type: {0}", EngineType);
        Console.WriteLine("Transmission: {0}", Transmission);
        Console.WriteLine("Convertible: {0}\n", Convertible);
    }
}
       
}


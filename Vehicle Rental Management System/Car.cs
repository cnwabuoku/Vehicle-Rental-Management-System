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
        Console.WriteLine("Car. Model: {0}, Manufacturer: {1}, Year: {2}, Rental Price: {3}", Model, Manufacturer, Year, RentalPrice);
        Console.WriteLine("     Seats: {0}, Engine Type: {1}, Transmission: {2}, Convertible: {3}\n", Seats, EngineType, Transmission, Convertible);
    }
}   
}


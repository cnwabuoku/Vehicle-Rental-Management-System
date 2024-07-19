using System;
using Microsoft.VisualBasic;

namespace VehicleRentalManagementSystem
{

public class Motorcycle : Vehicle
{
    // Motorcycle-specific properties
    public int EngineCapacity {get; set;}
    public string FuelType {get; set;}
    public bool HasFairing {get; set;}

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override DisplayDetails() method
    public override void DisplayDetails()
    {
        Console.WriteLine("Motorcycle. Model: {0}, Manufacturer: {1}, Year: {2}, Rental Price: {3}", Model, Manufacturer, Year, RentalPrice);
        Console.WriteLine("            Engine Capacity: {0}, Fuel type: {1}, Has Fairing: {2}\n", EngineCapacity, FuelType, HasFairing);
    }
}
}
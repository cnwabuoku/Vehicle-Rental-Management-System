using System;
using Microsoft.VisualBasic;

namespace VehicleRentalManagementSystem
{

public class Motorcycle : Vehicle
{
    public int EngineCapacity {get; set;}
    public string FuelType {get; set;}
    public bool HasFairing {get; set;}

    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

        public override void DisplayDetails()
        {
            Console.WriteLine("Motorcycle Details:");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Rental Price: {0}", RentalPrice);
            Console.WriteLine("Engine Capacity: {0}", EngineCapacity);
            Console.WriteLine("Fuel type: {0}", FuelType);
            Console.WriteLine("Has Fairing: {0}", HasFairing);
        }
    }
}
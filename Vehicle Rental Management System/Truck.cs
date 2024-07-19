using System;
 
namespace VehicleRentalManagementSystem
{

    public class Truck : Vehicle
    {
        // Truck-specific properties
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

    // Constuctor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override DisplayDetails() method
    public override void DisplayDetails()
    {
        Console.WriteLine("Truck. Model: {0}, Manufacturer: {1}, Year: {2}, Rental Price: {3}", Model, Manufacturer, Year, RentalPrice);
        Console.WriteLine("       Capacity: {0}, Truck Type: {1}, Four Wheel Drive: {2}\n", Capacity, TruckType, FourWheelDrive);
    }

    }
}
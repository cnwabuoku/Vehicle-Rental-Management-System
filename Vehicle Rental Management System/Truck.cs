using System;
 
namespace VehicleRentalManagementSystem
{

public class Truck : Vehicle
{
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWhealDrive { get; set; }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWhealDrive = fourWheelDrive;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Truck Details:");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Rental Price: {0}", RentalPrice);
            Console.WriteLine("Seats: {0}", Capacity);
            Console.WriteLine("Truck Type: {0}", TruckType);
            Console.WriteLine("Transmission: {0}", FourWhealDrive);
            Console.WriteLine("");
        }

    }
}
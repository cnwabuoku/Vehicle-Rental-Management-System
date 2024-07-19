using System;
 
namespace VehicleRentalManagementSystem
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Car("Model S", "Tesla", 2020, 99.99m, 5, "Electric", "Automatic", true);
            Vehicle truck = new Truck("F-150", "Ford", 2023, 249.99m, 1500, "Pickup", true);
            Vehicle motorcycle = new Motorcycle("Ninja 400", "Kawasaki", 2023, 45.99m, 399, "Gasoline", true);

            // car.DisplayDetails();
            // truck.DisplayDetails();
            // motorcycle.DisplayDetails();

            RentalAgency agency = new RentalAgency();

            // Add Vehicles available for rental
            agency.AddVehicle(car);
            agency.AddVehicle(truck);
            agency.AddVehicle(motorcycle);

            Console.WriteLine("\nCurrent fleet: ");
            agency.DisplayFleet();

            // Rent car
            agency.RentVehicle(car);
            Console.WriteLine("\nFleet after renting a car:");
            agency.DisplayFleet();

            Console.WriteLine("\nTotal Revenue: {0:C}\n", agency.TotalRevenue);

            // Rent motorcycle
            agency.RentVehicle(motorcycle);
            Console.WriteLine("\nFleet after renting vehicle(s):");
            agency.DisplayFleet();

            Console.WriteLine("\nTotal Revenue: {0:C}\n", agency.TotalRevenue);
            
            // Try to rent the same car previously rented 
            agency.RentVehicle(car);
        }
    }
}
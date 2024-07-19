using System;
using System.Collections.Generic;

namespace VehicleRentalManagementSystem
{
    
    public class RentalAgency
    {
        private List<Vehicle> Fleet { get; set; }
        public decimal TotalRevenue { get; private set; }

        public RentalAgency()
        {
            Fleet = [];             // Property for the list of vehicles
            TotalRevenue = 0;       // Property to track the total revenue earned by the rental agency
        }

        // Method to add a vehicle to the list
        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        // Method to remove a vehicle from the list
        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        // Method to rent a vehicle
        public void RentVehicle(Vehicle vehicle)
        {
            if (Fleet.Contains(vehicle))
        {
            Fleet.Remove(vehicle);
            TotalRevenue += vehicle.RentalPrice;
            Console.WriteLine($"Vehicle rented: {vehicle.Model}");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
        }

        // Method to display the list of vehicles available for rental
        public void DisplayFleet()
        {
            foreach (var vehicle in Fleet)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
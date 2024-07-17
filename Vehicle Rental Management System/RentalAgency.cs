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
            Fleet = [];
            TotalRevenue = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

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

        public void DisplayFleet()
        {
            foreach (var vehicle in Fleet)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
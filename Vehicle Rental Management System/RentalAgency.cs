using System;
using System.Collections.Generic;

namespace VehicleRentalManagementSystem
{
    
    public class RentalAgency
    {
        private List<Vehicle> _fleet { get; set; }
        public decimal TotalRevenue { get; private set; }

        public RentalAgency()
        {
            _fleet = new List<Vehicle>();             
            TotalRevenue = 0;       
        }

        // Method to add a vehicle to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            _fleet.Add(vehicle);
            Console.WriteLine("Vehicle: {0}, {1} added to fleet", vehicle.Manufacturer, vehicle.Model);
        }

        // Method to remove a vehicle from the list
        public void RemoveVehicle(Vehicle vehicle)
        {
            _fleet.Remove(vehicle);
            Console.WriteLine("Vehicle: {0}, {1} removed from fleet", vehicle.Manufacturer, vehicle.Model);
        }

        // Method to rent a vehicle
        public void RentVehicle(Vehicle vehicle)
        {
            if (_fleet.Contains(vehicle))
            {
                _fleet.Remove(vehicle);
                TotalRevenue += vehicle.RentalPrice;
                Console.WriteLine("Vehicle rented: {0}, {1}", vehicle.Manufacturer, vehicle.Model);
            }
            else
            {
                Console.WriteLine("Vehicle not available for rent.\n");
            }
        }

        // Method to display the list of vehicles available for rental
        public void DisplayFleet()
        {
            foreach (var vehicle in _fleet)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
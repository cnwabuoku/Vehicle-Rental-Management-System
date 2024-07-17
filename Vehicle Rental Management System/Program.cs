﻿using System;
 
namespace VehicleRentalManagementSystem
{

 public class Program
 {
    public static void Main(string[] args)
    {
        Car car = new Car("Model S", "Tesla", 2020, 99.99m, 5, "Electric", "Automatic", true);
        car.DisplayDetails();

        Truck truck = new Truck(" ", " ", 1995, 250, 10, " ", true );
        truck.DisplayDetails();
    }

 }

}
using System;
 
namespace VehicleRentalManagementSystem
{

    public abstract class Vehicle
    {
        // Private properties for the Vehicle class
        private string _model;
        private string _manufacturer;
        private int _year;
        private decimal _rentalPrice;

        // Public properties with getter and setter methods
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public decimal RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        // Protected constructor
        protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            _model = model;
            _manufacturer = manufacturer;
            _year = year;
            _rentalPrice = rentalPrice;
        }

        public abstract void DisplayDetails();

    }
}
using System;
 
namespace VehicleRentalManagementSystem
{

public abstract class Vehicle
{
    // Private properties for the Vehicle class
    private string model;
    private string manufacturer;
    private int year;
    private decimal rentalPrice;

    // Public properties with getter and setter methods
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public decimal RentalPrice
    {
        get { return rentalPrice; }
        set { rentalPrice = value; }
    }

    // Protected constructor
    protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.year = year;
        this.rentalPrice = rentalPrice;
    }

    public abstract void DisplayDetails();

}
}
// Q3. Single Level Inheritance - Vehicle → Car
//
// Real Picture: Vehicle (Parent) → Car (Child)
//
// Task 1  : Created class Vehicle (base class)
// Task 2  : Added private, protected, public data members in Vehicle
// Task 3  : Added public methods in Vehicle
// Task 4  : Car inherits from Vehicle (single level inheritance)
// Task 5  : Added private, protected, public data members in Car
// Task 6  : Added public methods in Car
// Task 7  : TUT4_Q3 is the Demo class with Main method
// Task 8  : Created two Car objects in Main and called all methods
// Task 9  : Comments added throughout the code
// Task 10 : Summary at the end of this file

/*
 * Summary:
 *   This program demonstrates Single Level Inheritance.
 *   The base class 'Vehicle' holds common vehicle properties like
 *   brand, speed, and fuel. The derived class 'Car' adds car-specific
 *   properties like number of doors and car type.
 *   Car inherits ShowVehicleInfo() from Vehicle and adds ShowCarInfo().
 *   Two Car objects are created in Main and all methods are called.
 */

using System;

// -----------------------------------------------------------------------
// Task 1, 2, 3 : Base class Vehicle
// -----------------------------------------------------------------------
class Vehicle
{
    // private data member - only accessible within Vehicle
    private   string brand;

    // protected data member - accessible in Vehicle and derived classes
    protected int    speed;

    // public data member - accessible everywhere
    public    string fuelType;

    // Constructor to initialise Vehicle data members
    public Vehicle(string brand, int speed, string fuelType)
    {
        this.brand    = brand;
        this.speed    = speed;
        this.fuelType = fuelType;
    }

    // Public method to get private brand name
    public string GetBrand()
    {
        return brand;
    }

    // Public method to display Vehicle information
    public void ShowVehicleInfo()
    {
        Console.WriteLine("  Brand     : " + GetBrand());
        Console.WriteLine("  Speed     : " + speed + " km/h");
        Console.WriteLine("  Fuel Type : " + fuelType);
    }
}

// -----------------------------------------------------------------------
// Task 4, 5, 6 : Derived class Car inherits from Vehicle
// -----------------------------------------------------------------------
class Car : Vehicle
{
    // private data member in Car
    private   int    numberOfDoors;

    // protected data member in Car
    protected string carType;

    // public data member in Car
    public    double price;

    // Constructor - calls base class constructor using base keyword
    public Car(string brand, int speed, string fuelType,
               int doors, string carType, double price)
        : base(brand, speed, fuelType)
    {
        numberOfDoors = doors;
        this.carType  = carType;
        this.price    = price;
    }

    // Method to get private numberOfDoors
    public int GetDoors()
    {
        return numberOfDoors;
    }

    // Method to display Car-specific information
    public void ShowCarInfo()
    {
        Console.WriteLine("  Car Type  : " + carType);
        Console.WriteLine("  Doors     : " + GetDoors());
        Console.WriteLine("  Price     : Rs." + price);
    }

    // Method to display full details (Vehicle + Car)
    public void ShowFullDetails()
    {
        Console.WriteLine("--- Vehicle Info ---");
        ShowVehicleInfo();       // inherited method from Vehicle
        Console.WriteLine("--- Car Info ---");
        ShowCarInfo();
        Console.WriteLine();
    }
}

// -----------------------------------------------------------------------
// Task 7 : Demo class with Main method
// -----------------------------------------------------------------------
class TUT4_Q3
{
    static void Main()
    {
        // Task 8: Create two Car objects and call all methods
        Car car1 = new Car("Toyota", 180, "Petrol",  4, "Sedan",   850000);
        Car car2 = new Car("Honda",  200, "Diesel",  2, "Coupe",  1200000);

        Console.WriteLine("======= Car 1 Details =======");
        car1.ShowFullDetails();

        Console.WriteLine("======= Car 2 Details =======");
        car2.ShowFullDetails();

        Console.ReadLine();
    }
}
// Output:
// ======= Car 1 Details =======
// --- Vehicle Info ---
//   Brand     : Toyota
//   Speed     : 180 km/h
//   Fuel Type : Petrol
// --- Car Info ---
//   Car Type  : Sedan
//   Doors     : 4
//   Price     : Rs.850000
//
// ======= Car 2 Details =======
// --- Vehicle Info ---
//   Brand     : Honda
//   Speed     : 200 km/h
//   Fuel Type : Diesel
// --- Car Info ---
//   Car Type  : Coupe
//   Doors     : 2
//   Price     : Rs.1200000

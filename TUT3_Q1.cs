using System;

namespace CalculatorApplication
{
    /*
     * =========================================================================
     * CLASS vs OBJECT DIAGRAM (Visualizing the difference)
     * =========================================================================
     * 
     *      [ CLASS ] (Blueprint / Template)
     *      +-----------------------------------------+
     *      | Class Name: Car                         |
     *      +-----------------------------------------+
     *      | - Private Attributes:                   |
     *      |   - string _make                        |
     *      |   - string _model                       |
     *      |   - int _year                           |
     *      +-----------------------------------------+
     *      | + Public Methods:                       |
     *      |   - SetDetails(make, model, year)       |
     *      |   - DisplayDetails()                    |
     *      +-----------------------------------------+
     *                           |
     *            Instantiates (new Car())
     *                           |
     *         +-----------------+-----------------+
     *         |                                   |
     *         v                                   v
     *   [ OBJECT 1: car1 ]                  [ OBJECT 2: car2 ]
     *   (Actual Instance in memory)         (Actual Instance in memory)
     *   +------------------------+          +------------------------+
     *   | _make  = "Toyota"      |          | _make  = "Honda"       |
     *   | _model = "Corolla"     |          | _model = "Civic"       |
     *   | _year  = 2021          |          | _year  = 2023          |
     *   +------------------------+          +------------------------+
     * 
     * =========================================================================
     * SOLUTION SUMMARY:
     * A "Class" serves as an abstract blueprint or definition (defining what properties
     * and methods a type has). An "Object" is a concrete, real instance of that class
     * created in computer memory.
     * =========================================================================
     */

    // Task 1: Create a class
    public class Car
    {
        // Task 2: Add few data members as private
        private string _make;
        private string _model;
        private int _year;

        // Task 3: Add few methods as public to work on defined data members
        public void SetDetails(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Car Details: {0} {1} ({2})", _make, _model, _year);
        }
    }

    // Task 4: Create a Demo class with main method
    public class TUT3_Q1
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            // Task 5: Create at least two objects of a class and call all methods using that object
            Car car1 = new Car();
            Car car2 = new Car();

            // Calling methods on car1
            car1.SetDetails("Toyota", "Corolla", 2021);
            car1.DisplayDetails();

            // Calling methods on car2
            car2.SetDetails("Honda", "Civic", 2023);
            car2.DisplayDetails();

            Console.ReadLine();
        }
    }
}

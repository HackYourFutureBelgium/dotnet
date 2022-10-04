using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Lesson3.Generics
{
    // Create a car factory class that contains a collection of cars.
    // It should have a method that can print the inventory of all the cars that were added to it
    // Print the specific properties of the cars as well.
    // E.g.: Jaguar with license plate '1-AZE-123' has colour black
    //          Lamborghini with license plate '2-RTY-456' has 6 windows


    //not great

    public class CarList<T>
    {

        private T List;

        public CarList(T list){ 
            List = list;
        }

        public void PrintOut(List<Car> value)
        {
            foreach (var item in value)
                if (item.Brand == Brand.Jaguar)
                    Console.WriteLine($"car is Jaguar, license plate number is: {item.LicensePlate}");
                else Console.WriteLine($"car is Lamborghini, license plate number is: {item.LicensePlate}");
            
        }
    }


        public class Car
    {
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public string LicensePlate { get; set; }
        public Brand Brand { get; set; }
    }

    public class Jaguar : Car
    {
        public Jaguar(string colour, string licensePlate) : base(licensePlate)
        {
            Colour = colour;
            Brand = Brand.Jaguar;
        }

        public string Colour { get; set; }
    }

    public class Lamborghini : Car
    {
        public Lamborghini(int numberOfWindows, string licensePlate) : base(licensePlate)
        {
            NumberOfWindows = numberOfWindows;
            Brand = Brand.Lamborghini;
        }

        public int NumberOfWindows { get; set; }
    }

    public enum Brand
    {
        Jaguar,
        Lamborghini
    }


    }

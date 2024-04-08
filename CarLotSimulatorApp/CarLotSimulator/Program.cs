using Microsoft.VisualBasic;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            CarLot lot = new CarLot();

          


            Car car1 = new Car()
            {
                Year = 2002,
                Make = "Ford",
                Model = "Truck",
                EngineNoise = "loud",
                HonkNoise = "a squeek",
                IsDriveable = true
            };
            Console.WriteLine($"Number of Cars {CarLot.NumberOfCars}");
            lot.ListOfCars.Add(car1);
         car1.MakeHonkNoise();

            Car car2 = new Car();
            car2.Make = "Tesla";
            car2.Year = 2024;
            car2.Model = "car";
            car2.EngineNoise = "no noise";
            car2.HonkNoise = "set to truck honk";
            car2.IsDriveable = true;
           
            lot.ListOfCars.Add(car2);
            car2.MakeEngineNoise();

            Car car3 = new Car("Farrari", "Fancy", 2024);
            car3.EngineNoise = "Howdy";
            car3.Make = "Farrari";
            car3.Year = 2024;
            car3.Model = "car";
            car3.MakeEngineNoise();
            lot.ListOfCars.Add(car3);

            Car car4 = new Car();
            car4.Make = "Toyota";
            car4.Year = 2017;
            car4.Model = "mini van";
            car4.EngineNoise = "constantly vibrateing clinkity clank";
            car4.HonkNoise = "a dull BEEP...";
            car4.IsDriveable = true;
            lot.ListOfCars.Add(car4);
            Car car5 = new Car()
            {
                Make = "Toyota",
                Year = 2020,
                Model = "car",
                EngineNoise = "slight vroom hum",
                HonkNoise = "a loud BEEEEEP",
                IsDriveable = true,
            };
            lot.ListOfCars.Add(car5);



            Person person1 = new Person();
            person1.NameOfPerson = "Yaakov";

            string personName = "Bob";

            person1.Greeting(person1.NameOfPerson);




            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars ,done
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list. done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("");
            foreach(Car item in lot.ListOfCars)
            {
                Console.WriteLine($"Make:{item.Make}");
                Console.WriteLine($"Model:{item.Model}");
                Console.WriteLine($"Year:{item.Year}");
                Console.WriteLine("");
            }





       }





       
       
    }
}

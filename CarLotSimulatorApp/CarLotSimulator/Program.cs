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
            
            Car car1 = new Car()
            {
                Year = 2002,
                Make = "Ford",
                Model = "Truck",
                EngineNoise = "loud",
                HonkNoise = "a squeek",
                IsDriveable = true
            };
            car1.MakeHonkNoise();

            Car car2 = new Car();
            car2.Make = "Tesla";
            car2.Year = 2024;
            car2.Model = "car";
            car2.EngineNoise = "no noise";
            car2.HonkNoise = "set to truck honk";
            car2.IsDriveable = true;

            car2.MakeEngineNoise();

            Car car3 = new Car("Farrari", "Fancy", 2024);
            car3.EngineNoise = "Howdy";
            car3.MakeEngineNoise();




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
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console







       }





       
       
    }
}

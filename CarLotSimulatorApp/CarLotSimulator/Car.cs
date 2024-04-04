using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{


    
    internal class Car
    {
        public Car()
        {

        }
        public Car(string make, string model, int year)
        {
            make = Make; 
            model = Model; 
            year = Year;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{Make}'s engine sounds like this: {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Make}'s honk noise sounds like this: {HonkNoise}");
        }

        
    }
}

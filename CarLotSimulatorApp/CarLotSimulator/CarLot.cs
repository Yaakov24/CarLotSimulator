using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public static string NumberOfCars { get; set; }

        public List<Car> ListOfCars { get; set; } = new List<Car>();


    }
}

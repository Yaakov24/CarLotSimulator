using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Person
    {
        public string NameOfPerson { get; set; }
        public void Greeting(string nameOfPerson)
        {
            Console.WriteLine($"Hey, {nameOfPerson}!");
        }
    }
}

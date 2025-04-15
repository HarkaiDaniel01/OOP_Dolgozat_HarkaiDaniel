using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dolgozat_HarkaiDániel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto toyota = new Auto("Toyota", "Corolla", 2015, 6.5, 152000);
            toyota.adatkiiras();

            Console.ReadKey();
        }
    }
}

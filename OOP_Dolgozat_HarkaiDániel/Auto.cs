using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dolgozat_HarkaiDániel
{
    internal class Auto
    {
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEv { get; set; }
        public double Fogyasztas { get; set; }
        public double MegtettKm { get; set; }

        public Auto(string marka, string tipus, int gyartasiEv, double fogyasztas, double megtettKm)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            Fogyasztas = fogyasztas;
            MegtettKm = megtettKm;
        }

        public int eletkor()
        {
            return DateTime.Now.Year - GyartasiEv;
        }

        public double uzemanyag_felhasznalas()
        {
            return Math.Round(MegtettKm * Fogyasztas / 100, 2);
        }

        public double atlagfogyasztas_kmre()
        {
            return Fogyasztas / 100;
        }

        public void adatkiiras()
        {
            Console.WriteLine("Autó adatai:");
            Console.WriteLine($"Márka: {Marka}");
            Console.WriteLine($"Típus: {Tipus}");
            Console.WriteLine($"Gyártási év: {GyartasiEv}");
            Console.WriteLine($"Életkor: {eletkor()} év");
            Console.WriteLine($"Fogyasztás: {Fogyasztas} l/100km");
            Console.WriteLine($"Megtett kilométer: {MegtettKm} km");
            Console.WriteLine($"Összesen felhasznált üzemanyag: {uzemanyag_felhasznalas()} liter");
            Console.WriteLine($"Átlagos fogyasztás 1 km-re: {atlagfogyasztas_kmre()} liter/km");
        }

    }
}

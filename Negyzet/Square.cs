using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyzet
{
    public class Square
    {
        // Tagváltozók
        public double Oldal { get; set; }
        public double Magas { get; set; }

        // Konstruktor
        public Square(double oldal)
        {
            Oldal = oldal;
            Magas = 0;
        }

        // Átmérő
        public double Atmero() { return Math.Sqrt(2 * Math.Pow(Oldal, 2)); }

        // Kerület
        public double Kerulet() { return 4 * Oldal; }

        // Terület
        public double Terulet() { return Math.Pow(Oldal, 2); }

        // Magasság beolvasása

        // Oszlop térfogata
        public double OszlopTerfogat()
        {
            if (Magas <= 0)
            {
                // Dobunk egy kivételt
                throw new ArgumentException("A magasságnak nullánál nagyobbnak kell lennie!");
            }

            return Terulet() * Magas;
        }

    }
}

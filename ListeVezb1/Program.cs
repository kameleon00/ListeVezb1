using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeVezb1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> godine = new List<int>() { 2009, 2010, 2011, 2012, 2013, 2014 };

            Console.Write("Pre dodavanja elemenata.");
            Console.WriteLine();
            Console.Write("Broj elemenata: " + godine.Count);
            Console.WriteLine();
            Console.Write("Kapacitet: " + godine.Capacity);
            Console.WriteLine();

            Console.WriteLine();

            godine.Add(2015);
            godine.Add(2016);
            godine.Add(2017);

            Console.Write("Posle dodavanja elemenata.");
            Console.WriteLine();
            Console.Write("Broj elemenata: " + godine.Count);
            Console.WriteLine();
            Console.Write("Kapacitet: " + godine.Capacity);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

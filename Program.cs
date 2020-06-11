using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abtraction.abtractionClass;
using Abtraction.Interface;

namespace Abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();
            hewan Hewan;

            Hewan = new herbivora();
            Hewan.jenisMakanan();

            Hewan = new karnivora();
            Hewan.jenisMakanan();

            Hewan = new omnivora();
            Hewan.jenisMakanan();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();
            IReproduksi reproduksiHewan;

            reproduksiHewan = new vivipar();
            reproduksiHewan.berkembangBiak();

            reproduksiHewan = new ovipar();
            reproduksiHewan.berkembangBiak();

            reproduksiHewan = new ovovivipar();
            reproduksiHewan.berkembangBiak();

            Console.ReadKey();
        }
    }
}

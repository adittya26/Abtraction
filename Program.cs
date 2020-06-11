using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abstraction.AbstractionClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();

            tumbuhan Tumbuhan;

            Tumbuhan = new monokotil();
            Tumbuhan.jenisTumbuhan();

            Tumbuhan = new dikotil();
            Tumbuhan.jenisTumbuhan();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();

            IAdaptasi adaptasi;

            adaptasi = new hidrofit();
            adaptasi.tempatHidupTumbuhan();

            adaptasi = new higrofit();
            adaptasi.tempatHidupTumbuhan();

            adaptasi = new xerofit();
            adaptasi.tempatHidupTumbuhan();


            Console.ReadKey();
        }
    }
}

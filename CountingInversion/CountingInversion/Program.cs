using System;
using System.Collections;
using System.IO;
namespace CountingInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileReader();
            file.ReadToArray("numbers.txt");
            var inv = new Inversion();
            var sor = inv.CountInversion(file.GetArray());
            Int64 a = inv.inversionCount;
            Console.WriteLine(a);
        }
    }
}

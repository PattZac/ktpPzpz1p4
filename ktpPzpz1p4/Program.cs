using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktpPzpz1p4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu: ");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Cijenu bez PDV-a: "+n+"."+"\r\nCijenu s PDV-om: "+n*1.25+".");
            Console.ReadKey();
        }
    }
}

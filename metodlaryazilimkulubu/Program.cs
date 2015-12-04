using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlaryazilimkulubu
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama(3, 5);
            Toplama(4, 5);
            Toplama(9, 3);
            Toplama(4, 5);
            Console.ReadLine();
        }

        private static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caminhada
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr, result;
            Console.WriteLine("Quantas horas você percorreu?: ");
            hr = int.Parse(Console.ReadLine());
            result = 8 * hr;
            Console.WriteLine("você percorreu: " + result + " Km.");
            Console.ReadKey();

        }
    }
}

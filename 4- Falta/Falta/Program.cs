using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Falta
{
    class Program
    {
        static void Main(string[] args)
        {
            int falt, result, tot;

            Console.WriteLine("Digite os dias faltados: ");
            falt = int.Parse(Console.ReadLine());
            result = falt * 8;
            tot = (26 * 8) - result;
            Console.WriteLine("Você trabalha 8 horas em um mês e 30 dias com 4 dias de descanso. Você trabalhou em um mês: " + tot + " horas.");
            Console.ReadKey();
        }
    }
}

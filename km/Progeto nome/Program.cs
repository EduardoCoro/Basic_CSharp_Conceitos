using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progeto_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, result;
            Console.WriteLine("Quantas horas você percorreu ?");
            horas= int.Parse(Console.ReadLine());
            result = horas * 8;
            Console.WriteLine("Você percorreu "+result);
            Console.ReadKey();  

        }
    }
}

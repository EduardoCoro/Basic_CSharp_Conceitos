using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
           string  n,s;

            Console.WriteLine("Digita seu nome: ");
            n=(Console.ReadLine());
            Console.WriteLine("Digita seu sobrenome: ");
            s=(Console.ReadLine());
            Console.WriteLine("Seu nome completo é : " + n + " " + s);
            Console.ReadKey();
        }
    }
}

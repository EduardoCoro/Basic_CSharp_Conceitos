using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anonome
{
    class Program
    {
        static void Main(string[] args)
        {
            string n ;
            int nas, atu, tl;

            Console.WriteLine("Digite o seu nome completo: ");
            n=(Console.ReadLine());
            Console.WriteLine ("Digite o seu ano de nascimento: ");
            nas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            atu = int.Parse(Console.ReadLine());
            tl = atu - nas;
            Console.WriteLine("Seu nome completo é: " +n+ " você tem: " + tl + " anos.");
            Console.ReadKey();
        }
    }
}

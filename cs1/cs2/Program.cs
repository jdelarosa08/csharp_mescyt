using System;

namespace cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            string tipo;

            Console.WriteLine("digite un numero");
            num = Console.Read();

            tipo = num % 2 == 0 ? num = "par" : num = "impar"; //operador altelnario .... 
            Console.WriteLine(tipo);

        }
    }
}

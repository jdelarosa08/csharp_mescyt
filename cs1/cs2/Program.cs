using System;

namespace cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tipo = "par";
            var num = 0;
            string tipo;

            Console.WriteLine("digite un numero");
            num = Console.Read();

            tipo = (num % 2) == 0 ? "par" : "impar"; //operador altelnario .... 
            Console.WriteLine(tipo);
            //var  x = 10;
            //var y = (x > 9) ? 100 : 200;
            //Console.WriteLine(y);


        }
    }
}

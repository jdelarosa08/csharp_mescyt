using System;

namespace cs3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = promedio(1, 2, 3, 4, 5, 6, 8, 9,10);
            var b = avg(1, 23, 4, 56, 7, 8, 4, 5);
            Console.WriteLine("el Promedio es {0}", a);
            Console.WriteLine("el Promedio es {0}", b);
        }

        static float promedio(params int[] numeros)
        {
            int sum = 0;
            foreach(int x in numeros){
                sum += x;
            }
            return sum/numeros.Length;
        }

        static float avg(params int[] numeros)
        {
            int count = 0;
            int sum = 0;
            float average = 0;
            foreach(int x in numeros){
                sum += x;
                count = count+1;

            }
            average = sum / count;
            return average;
        }
    }
}

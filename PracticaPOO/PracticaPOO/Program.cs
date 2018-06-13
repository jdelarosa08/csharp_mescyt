using System;

namespace PracticaPOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            clsGaraje garaje = new clsGaraje();
            clsCoche carro1 = new clsCoche();
            clsCoche carro2 = new clsCoche();

            double importe; 
            var rand = new Random();

            importe = rand.Next(100, 10000);

            garaje.aceptarCoche(carro1, importe);


        }
    }
}

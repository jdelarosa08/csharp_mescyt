using System;
namespace PracticaPOO
{
    public class clsGaraje
    {
        public clsCoche coche;
        public string averia_asociada;
        public int numero_de_coche;

        public bool aceptarCoche(clsCoche carro=null, string averia = null)
        {
            bool aceptar = true;
            coche = carro;
            averia_asociada = averia;
            if( coche != null && averia_asociada == null)
            {
                aceptar = false;   
            }

            return aceptar;
            
        }
        public void devolverCoche()
        {
            aceptarCoche(null, null);
        }
    }
}

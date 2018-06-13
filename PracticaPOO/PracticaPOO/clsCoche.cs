using System;
namespace PracticaPOO
{
    public class clsCoche
    {
        private clsMotor motor; 

        public string marca 
        { 
            get; 
        }
        public string modelo 
        { 
            get; 
        }
        public double precio_averias 
        { 
            get; 
        }

        public double acumularAveria()
        {
            var suma = 0.0;
            suma =+precio_averias;
            return suma;
        }
    }
}

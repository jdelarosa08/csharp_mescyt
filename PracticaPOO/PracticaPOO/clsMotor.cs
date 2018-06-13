using System;
namespace PracticaPOO
{
    public class clsMotor
    {
        public int Litro_de_Aceite 
        { 
            get; 
            set; 
        }
        public int Potencia 
        { 
            get; 
            set; 
        } 
        public clsMotor(int pot)
        {
            Potencia = pot;
            Litro_de_Aceite = 0;
        }
    }
}

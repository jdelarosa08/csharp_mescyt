using System;
namespace cs3
{
    public class clsAsignatura
    {

        //private int identificador;
        //private double calificacion;


        public int Identificador
        {
            get;
            set;
        }

        public double Calificacion
        {
            get;
            set;
        }

        public clsAsignatura(int id)
        {
            Identificador = id;
        }
    }
}

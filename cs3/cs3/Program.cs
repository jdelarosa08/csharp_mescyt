using System;

namespace cs3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            clsAsignatura matematica = new clsAsignatura(1010);
            clsAsignatura biologia = new clsAsignatura(1234);
            clsAsignatura historia = new clsAsignatura(1123);

            clsAlumno daniel = new clsAlumno(biologia, matematica, historia);

            clsProfesro prof1 = new clsProfesro();

            prof1.ponerNotas(daniel);
            var resultado = prof1.calcularMedia(daniel);
            Console.WriteLine(" Promedio nota Estudiante daniel: {0}", resultado);


        }
    }
}

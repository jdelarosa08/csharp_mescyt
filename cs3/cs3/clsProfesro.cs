using System;
namespace cs3
{
    public class clsProfesro
    {
        public void ponerNotas(clsAlumno alumno)
        {
            var rand = new Random();

            alumno.Asignatura1.Calificacion = rand.Next(10, 100);
            alumno.Asignatura2.Calificacion = rand.Next(10, 100);
            alumno.Asignatura3.Calificacion = rand.Next(10, 100);
        }

        public double calcularMedia(clsAlumno alumno)
        {
            var suma = alumno.Asignatura1.Calificacion + alumno.Asignatura2.Calificacion + alumno.Asignatura3.Calificacion;
            var promedio = suma / 3;
            return promedio;

        }

        public void reporteCalificacion(clsAlumno alumno)
        {
            Console.WriteLine("Calificacion #1 {0}", alumno.Asignatura1.Calificacion);
            Console.WriteLine("Calificacion #2 {0}", alumno.Asignatura2.Calificacion);
            Console.WriteLine("Calificacion #3 {0}", alumno.Asignatura3.Calificacion);
        }
    }
}

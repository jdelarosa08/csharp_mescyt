using System;
namespace cs3
{
    public class clsAlumno
    {
        //private clsAsignatura asignatura1;
        //private clsAsignatura asignatura2;
        //private clsAsignatura asignatura3;

        public clsAsignatura Asignatura1
        {
            get;
        }

        public clsAsignatura Asignatura2
        {
            get;
        }

        public clsAsignatura Asignatura3
        {
            get;
        }
       
        public clsAlumno(clsAsignatura p1, clsAsignatura p2, clsAsignatura p3)
        {
            Asignatura1 = p1;
            Asignatura2 = p2;
            Asignatura3 = p3;

        }

        public clsAlumno(int p1, int p2, int p3)
        {
            Asignatura1 = new clsAsignatura(p1);
            Asignatura2 = new clsAsignatura(p2);
            Asignatura3 = new clsAsignatura(p3);
                
        }
    }
}

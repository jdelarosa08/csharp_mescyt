using System;

namespace Ejercicio1LP2_Joan
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOpcionUsuario = 0;
            while (nOpcionUsuario !=9)
            {
                mostrarMenu();
                try
                {
                    nOpcionUsuario = int.Parse(Console.ReadLine());
                    procesarPeticion(nOpcionUsuario);
                    
                }
                catch(Exception error)
                {
                    Console.WriteLine("\n\t Ha ocurrido un Error al procesar solicitud:\n\t" +
                                      error.Message + "|n\t Presione una tecla para continuar");
                    Console.ReadLine();
                }

            }

        }
        static void mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t Aplicacion de Consola con Lenguaje C#");
            Console.WriteLine("\t\t\t Menu de operaciones \n");
            Console.WriteLine("\t 1. Suma");
            Console.WriteLine("\t 2. Resta");
            Console.WriteLine("\t 3. Multiplicacion");
            Console.WriteLine("\t 4. Division");
            Console.WriteLine("\t 5. Modulo");
            Console.WriteLine("\t 9. Salir ");
            Console.Write("\t Seleccione una opccion: ");

        }
        static void procesarPeticion(int opcionUsuario)
        {
            double nOperandoUno = 0;
            double nOperandoDos = 0;

            switch (opcionUsuario)
            {
                case 1:
                    Console.Write("\n\t Ingrese el primer Numero: ");
                    nOperandoUno = double.Parse(Console.ReadLine());
                    Console.Write("\t Ingrese elSegundo Numero:");
                    nOperandoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t El Resultado de suma {0} y {1} es {2}",
                                      nOperandoUno, nOperandoDos, nOperandoUno + nOperandoDos);
                    Console.WriteLine("\t Presione una tecla para continuar");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("\n\t Ingrese el primer Numero: ");
                    nOperandoUno = double.Parse(Console.ReadLine());
                    Console.Write("\t Ingrese elSegundo Numero:");
                    nOperandoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t El Resultado de resta {0} y {1} es {2}",
                                      nOperandoUno, nOperandoDos, nOperandoUno - nOperandoDos);
                    Console.WriteLine("\t Presione una tecla para continuar");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("\n\t Ingrese el primer Numero: ");
                    nOperandoUno = double.Parse(Console.ReadLine());
                    Console.Write("\t Ingrese elSegundo Numero:");
                    nOperandoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t El Resultado de producto {0} y {1} es {2}",
                                      nOperandoUno, nOperandoDos, nOperandoUno * nOperandoDos);
                    Console.WriteLine("\t Presione una tecla para continuar");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Write("\n\t Ingrese el primer Numero: ");
                    nOperandoUno = double.Parse(Console.ReadLine());
                    Console.Write("\t Ingrese elSegundo Numero:");
                    nOperandoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t El Resultado de cociente {0} y {1} es {2}",
                                      nOperandoUno, nOperandoDos, nOperandoUno / nOperandoDos);
                    Console.WriteLine("\t Presione una tecla para continuar");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Write("\n\t Ingrese el primer Numero: ");
                    nOperandoUno = double.Parse(Console.ReadLine());
                    Console.Write("\t Ingrese elSegundo Numero:");
                    nOperandoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t El Resultado de el modulo {0} y {1} es {2}",
                                      nOperandoUno, nOperandoDos, nOperandoUno % nOperandoDos);
                    Console.WriteLine("\t Presione una tecla para continuar");
                    Console.ReadLine();
                    break;
                case 9:
                    {
                        Console.WriteLine("\t Gracias por utilizar nuestro sistema");
                        Console.WriteLine("\t Presione una tecla para continuar");
                        Console.ReadLine();
                        break;

                    }
                default:
                    Console.WriteLine("\t La opcion seleccionada no se encuentra disponbile. Intente nuevamente");
                    Console.ReadLine();
                    break;
            }
        }

    }
}

using System;
using Capa_Procesos;


namespace Semana4_tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int opc = 0;
            

            //instanciamos las clases
            cls_Ejercicios cls_Ejercicios = new cls_Ejercicios();

            while (opc != 8) //Menu de opciones
            {
                try
                {
                    Console.WriteLine("\n******Bienvenid@******\n " +
                        "Digite lo que desea hacer: " +
                    "\n1. Cantidad a pagar por cursos matricuados" +
                    "\n2. Calcular el valor de transporte de un paquete" +
                    "\n3. Calcular el salario de un trabajador?" +
                    "\n4. Calcular el área de un terreno " +
                    "\n5. Validar por su área si un terreno es apto para construcción" +
                    "\n6. Calcular promedio de un estudiante" +
                    "\n7. Calcular el precio de venta de los articulos de" +
                    " la empresa MUCHA PLATA" +
                    "\n8. Salir de este menu\n" +
                    "");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            cls_Ejercicios.Ejercicio2();
                            break;
                        case 3:
                           
                            break;
                        case 4:
                            cls_Ejercicios.Ejercicio4();
                            break;
                        case 5:

                            break;
                        case 6:
                            cls_Ejercicios.Ejercicio6();
                            break;
                        case 7:

                            break;
                        case 8:
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe digitar un numero del Menu");

                }

            }

            Console.WriteLine("\n" +
                    "*****************************************************\n" +
                    "*Muchas gracias !! Digite cualquier tecla para salir*" +
                  "\n*****************************************************");
            Console.ReadKey();

        }
    }

}


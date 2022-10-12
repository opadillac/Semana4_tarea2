using System;




namespace Capa_Procesos
{
    public class cls_Ejercicios
    {
        public void Ejercicio2()
        {
            Console.WriteLine("**** EJERCICIO 2 ****");
            Console.Write("DIGITE EL PESO EN KG DEL PAQUETE: ");
            double Kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE EL VALOR APROXIMADO DEL CONTENIDO DEL PAQUETE: ");
            double Valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE LOS KILOMETROS DE RECORRIDO: ");
            double Kilometraje = Convert.ToDouble(Console.ReadLine());

            double TKilo = Kilo * 100;
            double TValor = Valor * 0.10;
            double Tkilometraje = Kilometraje * 500;

            double Total = TKilo + TValor + Tkilometraje;

            Console.WriteLine("\n EL COSTO TOTAL DEL TRANSPORTE ES DE: " + Total);
            Console.Read();
        }

        public void Ejercicio4()
        {
            string msj;
            Console.WriteLine("**** EJERCICIO 4 ****");
            Console.Write("DIGITE EL LARGO DEL TERRENO: ");
            double Largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE EL ANCHO DEL TERRENO: ");
            double Ancho = Convert.ToDouble(Console.ReadLine());

            double Area = Largo * Ancho;

            if (Area > 100)
            {
                msj = "TERRENO APTO PARA CONSTRUCCIÓN";
            }
            else
            {
                msj = "TERRENO NO APTO PARA CONSTRUCCIÓN";
            }

            Console.WriteLine("\n EL AREA DEL TERRENO ES DE: " + Area + "\n" + msj);
            Console.Read();
        }

        public void Ejercicio6()
        {
            string msj;
            Console.WriteLine("**** EJERCICIO 6 ****");
            Console.Write("DIGITE EL NOMBRE DEL ESTUDIANTE: ");
            string Nombre = Console.ReadLine();
            Console.Write("DIGITE LA NOTA DEL PRIMER EXAMEN: ");
            double Uno = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE LA NOTA DEL SEGUNDO EXAMEN: ");
            double Dos = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE LA NOTA DEL TERCER EXAMEN: ");
            double Tres = Convert.ToDouble(Console.ReadLine());

            double Promedio = ((Uno + Dos + Tres) / 3);

            if (Promedio >= 70 && Tres >= 80)
            {
                msj = "APROBADO";
            }
            else if (Promedio > 60 && Uno >= 90)
            {
                msj = "APROBADO";
            }
            else if (Promedio > 60 && Dos >= 90)
            {
                msj = "APROBADO";
            }
            else if (Promedio > 60 && Tres >= 90)
            {
                msj = "APROBADO";
            }
            else
            {
                msj = "REPROBADO";
            }

            Console.WriteLine("EL PROMEDIO DEL ALUMNO: " + Nombre + ", ES DE: " + Promedio + ".\n EL ESTADO DEL ALUMNO ES: " + msj);
            Console.Read();
        }
    }
}

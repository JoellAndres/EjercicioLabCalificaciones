using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAlumnos;
            const float inferior = 0.0f, superior = 10.0f;
            float suma = 0.0f, promedio = 0.0f;
            float nMay, nMen;

            try{
                Console.Write("Ingrese la cantidad de alumnos: ");
                nAlumnos = Convert.ToInt32(Console.ReadLine());

            }catch(Exception e){
                Console.WriteLine("Ha ocurrido una excepcion: "+ e);
            }
            

            float[] calificaciones = new float[nAlumnos];

            //Pidiendo calificaciones
            try
            {
                for(int i=0; i<nAlumnos; i++)
                {
                    Console.Write("Ingrese la calificación: ");
                    calificaciones[i] = Convert.ToSingle(Console.ReadLine());

                    while((calificaciones[i] < inferior) || (calificaciones[i] > superior))
                    {
                        Console.WriteLine("\nLa calificacion debe estar entre (0 - 10)");
                        Console.Write("Ingrese la calificación: ");
                        calificaciones[i] = Convert.ToSingle(Console.ReadLine());
                    }
                }

            }catch(Exception e){
                Console.WriteLine(e);
            }
            

            //Obteniendo el promedio
            for(int i=0; i<nAlumnos; i++)
            {
                suma += calificaciones[i];
            }

            promedio = suma / nAlumnos;

            //Obteniendo calificación máxima y mínima
            nMay = calificaciones[0];
            nMen = calificaciones[0];            
            for (int i=0; i<nAlumnos; i++)
            {                               
                if (calificaciones[i] > nMay)
                    nMay = calificaciones[i];

                if (calificaciones[i] < nMen)
                    nMen = calificaciones[i];         
            }

            //Mostrando datos
            Console.Clear();
            Console.WriteLine("El promedio es: " + promedio + "\n");
            Console.WriteLine("La nota mayor es: " + nMay + "\n");
            Console.WriteLine("La nota menor es: " + nMen + "\n");
            Console.ReadKey();
        }
    }
}

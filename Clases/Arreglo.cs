using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArray.Clases
{
    internal class Arreglo
    {
        public void crearArreglo()
        {
            Console.WriteLine("Asignar Tamaño Maximo Arreglo: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] arg = new int[max];

            int n = -1;
            while (n <= max)
            {
                n++;
                if (n < max)
                {
                    Console.WriteLine("Introducir valor en: Indice " + (n + 1));
                    arg[n] = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Arreglo Lleno");
                    foreach(int elemento in arg)
                    {
                        Console.WriteLine(elemento);
                    }
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

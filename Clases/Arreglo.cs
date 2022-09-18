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

            int n = 0;
            while (n <= max)
            {
                if (n < max)
                {
                    n++;
                    Console.WriteLine("Introducir valor en: Indice " + n);
                    Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Arreglo Lleno");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

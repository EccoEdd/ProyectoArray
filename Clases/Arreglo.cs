using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArray.Clases
{
    internal class Arreglo
    {
        public void CrearArreglo()
        {
            Console.WriteLine("Asignar Tamaño Maximo Arreglo: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] Arreglo = new int[max];
            Console.ReadKey();
        }
    }
}

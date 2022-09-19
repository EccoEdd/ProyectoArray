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
            int[] arg = new int[max];

            int n = -1;
            while (n <= max)
            {
                n++;
                if (n < max)
                {
                    Console.WriteLine("Introducir valor en: Indice " + (n + 1));
                    try
                    {
                        arg[n] = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        arg[n] = 0;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Arreglo Lleno");
                    Mostrar(arg);
                    break;
                }
            }
            Console.ReadKey();
        }

        public void TrabajarDesordenado()
        {
            char s = 'y', a;
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
                    try
                    {
                        arg[n] = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        arg[n] = 0;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Arreglo Lleno");
                    break;
                }
            }
            Console.ReadKey();
            do
            {
                Console.WriteLine("Accion a Realizar(" +
                    "Buscar -> b, " +
                    "Eliminar -> e, " +
                    "Modificar -> m, " +
                    "Mostrar -> o)");
                a = Convert.ToChar(Console.ReadLine());
                switch (a)
                {
                    case 'b':
                        BuscarDesordenado(arg);
                        break;
                }
                Console.WriteLine("Seguir trabajando?(y/n): ");
                s = Convert.ToChar(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            } while (s == 'y');
        }

        public static void Mostrar(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }

        public static void BuscarDesordenado(int[] arreglo)
        {
            Console.WriteLine("Buscar elemento: ");
            int val = Convert.ToInt32(Console.ReadLine());
        }    
    }
}

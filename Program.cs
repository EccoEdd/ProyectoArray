using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Clases.Arreglo Argl = new Clases.Arreglo();

            Console.WriteLine("Accion a realizar(" +
                "Crear Normal -> 1, " +
                "Trabajar Desordenado -> 2" +
                "): ");
            int var = Convert.ToChar(Console.ReadLine());
            switch (var)
            {
                case '1':
                    Argl.CrearArreglo();
                    break;
                case '2':
                    Argl.TrabajarDesordenado();
                    break;
                default:
                    Console.WriteLine("No existente");
                    break;
            }
            Console.ReadKey();
        }
    }
}

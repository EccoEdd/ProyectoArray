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
            Argl.CrearArreglo();

            Console.WriteLine("Accion a realizar(): ");
            
            
            Console.ReadKey();
        }
    }
}

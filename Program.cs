using ProyectoFinal_Antozzi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ventas ventas = new Ventas();
            ventas.IdUsuario = 3;
            Console.WriteLine(ventas.getIdUsuario());
            Console.ReadLine();
            List<string> lista = new List<string>();
        }
    }
}

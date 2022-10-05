using ProyectoFinal_Antozzi.Controller;
using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.JSON;
using ProyectoFinal_Antozzi.Model.SQLServer;
using ProyectoFinal_Antozzi.Services;
using ProyectoFinal_Antozzi.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IProductoModel productosSql = new ProductoModel();
            if (productosSql.GetAll() != null)
            {
                foreach (Producto prod in productosSql.GetAll())
                {
                    Console.WriteLine(prod);
                }
            }

            Console.WriteLine("Producto id 3: " + productosSql.Get(3));
            */
            ProductoServices productServices = new ProductoServices();
            Producto producto = new Producto("Lampara",4000.63,500,5,1);
            Producto producto2 = new Producto("Mouse",400.63,500,5,1);
            Producto producto3 = new Producto("Lampara",4000.63,500,5,1);

             MenuController menuInicio = new MenuController();
             menuInicio.MenuInicio();
            //productServices.Update(producto2, 10);
            //productServices.Delete(2);
            // Console.WriteLine(producto.ToString());
            Console.ReadKey();
        }
    }
}

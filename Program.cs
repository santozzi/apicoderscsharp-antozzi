using ProyectoFinal_Antozzi.Controller;
using ProyectoFinal_Antozzi.Controller.Menus;
using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;

using ProyectoFinal_Antozzi.Model.SQLServer;
using System;



namespace ProyectoFinal_Antozzi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IProductoModel productosSql = new ProductoModel();
            //Producto producto = new Producto("Notebook", 4000.5, 500, 5, 1);
            //productosSql.Delete(3);
            //Usuario usuario = new Usuario("Maggie","SolisAlvear","mantozzi","22345","mantozzi@gmail.com");
            //IUsuarioModel  usuarioSql = new UsuarioModel();
            //usuarioSql.Update(usuario, 5);
            //usuarioSql.Delete(2);
            //productosSql.Update(producto,19);
            //usuarioSql.Add(usuario);
            //Usuario usuario = usuarioSql.Get(22 );
            /*
            foreach(Usuario usuario in usuarioSql.GetAll())
            {
                  Console.WriteLine(usuario);

            }
            */



            //int id = Convert.ToInt32(productosSql.Add(producto).Id);
            //Producto prodGet = productosSql.Get(id);
            //Console.WriteLine(prodGet);

            /*
            if (productosSql.GetAll() != null)
            {
                foreach (Producto prod in productosSql.GetAll())
                {
                    Console.WriteLine(prod);
                }
            }

            Console.WriteLine("Producto id 3: " + productosSql.Get(3));
            
            
            ProductoServices productServices = new ProductoServices();
            Producto producto = new Producto("Lampara",4000.63,500,5,1);
            Producto producto2 = new Producto("Mouse",400.63,500,5,1);
            Producto producto3 = new Producto("Lampara",4000.63,500,5,1);
            */
            MenuController menuInicio = new MenuTestController();
            

            //menuInicio.MenuInicio();
            //productServices.Update(producto2, 10);
            //productServices.Delete(2);
            // Console.WriteLine(producto.ToString());
            Console.ReadKey();
        }
    }
}

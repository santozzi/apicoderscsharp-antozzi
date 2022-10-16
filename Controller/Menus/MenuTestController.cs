using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;
using ProyectoFinal_Antozzi.Services;
using ProyectoFinal_Antozzi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Controller.Menus
{
    internal class MenuTestController : MenuController
    {  
        protected List<String> menuOptions;
        public MenuTestController()
        {

            this.menuOptions = new List<String>();
             menuOptions.Add("Traer Usuario");
             menuOptions.Add("Traer Producto");
             menuOptions.Add("Traer Productos Vendidos");
             menuOptions.Add("Traer Ventas");
             menuOptions.Add("Salir");
            this.menu = new Menu("Traer", menuOptions);
            this.productoServices = new ProductoServices(); 
            this.usuarioServices = new UsuarioServices();
            this.productoVendidoServices = new ProductoVendidoServices();
            this.ventaServices = new VentaServices();
            ShowMenu();


        }
        private void ShowMenu()
        {
            Console.Clear();
           
            int opcion = menu.ShowMenu();
            if (opcion == 0)
            {
                TraerUsuario();
            }
            else if (opcion == 1)
            {
                TraerProducto();
            }
            else if (opcion == 2)
            {
                TraerProductosVendidos();
            }
            else if (opcion == 3)
            {
                TraerVentas();
            }
            else {
                Salir();
            }
          
        }

        private void TraerUsuario() {
            Console.Clear();
            Console.Write("Ingrese el nombre de usuario: " );
            string nombreUsuario = Console.ReadLine();
            Usuario usuario = usuarioServices.GetByNombreUsuario(nombreUsuario);
            if (usuario == null)
            {
                ShowMenu();
            }
            else { 
               Console.WriteLine($"Id: {usuario.Id}");
               Console.WriteLine($"Nombre: {usuario.Nombre}");
               Console.WriteLine($"Apellido: {usuario.Apellido}");
               Console.WriteLine($"Nombre de Usuario: {usuario.NombreUsuario}");
               Console.WriteLine($"Contraseña: {usuario.Contraseña}");
               Console.WriteLine($"Mail: {usuario.Mail}");
               Console.ReadKey();
               ShowMenu();
            }

        }
        private void TraerProducto()
        {
            Console.Clear();
            Console.Write("Ingrese el Id del usuario: ");
            int idUsuario = Convert.ToInt32(Console.ReadLine());
            List<Producto> productos = productoServices.GetByIdUsuario(idUsuario);
            foreach (Producto producto in productos) { 
               Console.WriteLine(producto.ToString());  
            }
            Console.ReadKey();
            ShowMenu();
        }

        private void TraerProductosVendidos() {
            Console.Clear();
            Console.Write("Ingrese el nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();
            List<Producto> productos = productoVendidoServices.GetByUserName(nombreUsuario);
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
            if (productos.Count == 0)
            {
                Console.WriteLine("Ese usuario no tiene productos vendidos");
            }
            Console.ReadKey();
            ShowMenu();
        }
        private void TraerVentas() {
            Console.Clear();
            Console.Write("Ingrese el Id del usuario: ");
            int idUsuario = Convert.ToInt32(Console.ReadLine());
            List<Venta> ventas = ventaServices.GetVentasByIdUsuer(idUsuario);
            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta.ToString());
            }
            if (ventas.Count == 0) {
                Console.WriteLine("El usuario no tiene ventas");
            }
            Console.ReadKey();
            ShowMenu();
        }
    }
}

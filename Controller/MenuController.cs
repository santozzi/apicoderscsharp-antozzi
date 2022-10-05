using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Services;
using ProyectoFinal_Antozzi.View;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Controller
{
    internal class MenuController
    {
        private Menu menu;
        private ProductoServices productServices;
        private List<string> menuOptions;
        public MenuController() {
            productServices = new ProductoServices();

        }
       
        public void MenuInicio() { 
          menuOptions = new List<string>();
            menuOptions.Add("Agregar productos");
            menuOptions.Add("Mostrar productos");
            menuOptions.Add("Mostrar producto por id");
            menuOptions.Add("Actualizar producto");
            menuOptions.Add("Eliminar producto");
            menuOptions.Add("Salir");
            //this.menu = new Menu();
            this.menu = new Menu("MENU PRINCIPAL",menuOptions);
            ShowMenu();



           // firma();
        }
        private int ShowMenu() { 
        Console.Clear();
        //int opcion = menu.ShowMenu("MENU PRINCIPAL",menuOptions);
        int opcion = menu.ShowMenu();
            if (opcion == 0)
            {
                AgregarProductos();
                ShowMenu();
            }
            else if (opcion == 1)
            {
                MostrarProductos();
                ShowMenu();
            }
            else if (opcion == 2)
            {
                MostrarProductoById();
                ShowMenu();
            }
            else if (opcion == 3)
            {
                ActualizarProducto();
                ShowMenu();
            }
            else if (opcion == menuOptions.Count - 1)
            {
                Console.Clear();
                firma();
            }
            opcion = -1;
            return opcion;
        }
        private void AgregarProductos() {
            Console.Clear();
            Producto nuevo = new Producto();
            Console.WriteLine("Agregar un producto");
            Console.WriteLine("===================");

            Console.Write("Ingrese la descripción: ");
            nuevo.Descripcion= Console.ReadLine();
            
            Console.Write("Ingrese el costo: ");
            nuevo.Costo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese el precio de venta: ");
            nuevo.PrecioDeVenta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el stock: ");
            nuevo.Stock = Convert.ToInt32(Console.ReadLine());

            productServices.Add(nuevo);
           


        }
        private void MostrarProductos() {
            Console.Clear();
            List<Producto> productos = productServices.GetAll();
            for (int i=0;i<productos.Count;i++ ) {
                Producto producto = productos[i];
                string cadena = $"id: {producto.Id} Descripcion: {producto.Descripcion} Costo: {producto.Costo} Venta: {producto.PrecioDeVenta} Stock: {producto.Stock}";
                Console.WriteLine(cadena);
            }
            Console.ReadKey();
         
        }
        private void MostrarProductoById()
        {
            Console.Clear();
            Console.Write("Ingrese el id del producto: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
                Producto producto = productServices.Get(id);
                string cadena = $"id: {producto.Id} Descripcion: {producto.Descripcion} Costo: {producto.Costo} Venta: {producto.PrecioDeVenta} Stock: {producto.Stock}";
                Console.WriteLine(cadena);
        
            Console.ReadKey();

        }

        private void ActualizarProducto() 
        {
            List<Producto> products = productServices.GetAll();
            List<string> descriptions = new List<string>();
            foreach (Producto producto in products) {
                descriptions.Add(producto.ToString());
            }
            Console.Clear();
            int opcion = menu.ShowMenu("PRODUCTOS", descriptions);
            Producto productSelected = products[opcion];
            //Console.WriteLine();
            List<string> editProduct = new List<string>();
            editProduct.Add("Descripcion: "+productSelected.Descripcion);
            editProduct.Add("Costo: "+productSelected.Costo);
            editProduct.Add("Precio de venta: "+productSelected.PrecioDeVenta);
            editProduct.Add("Stock: "+productSelected.Stock);
            Console.Clear();
            opcion = menu.ShowMenu("Id: "+productSelected.Id, editProduct);
            Console.ReadKey();
        }
        
        
        public void firma() {

        string firma = @"

        ██████╗ ██╗   ██╗                              
        ██╔══██╗╚██╗ ██╔╝                              
        ██████╔╝ ╚████╔╝                               
        ██╔══██╗  ╚██╔╝                                
        ██████╔╝   ██║                                 
        ╚═════╝    ╚═╝                                 
    ███████╗███████╗██████╗  ██████╗ ██╗ ██████╗       
    ██╔════╝██╔════╝██╔══██╗██╔════╝ ██║██╔═══██╗      
    ███████╗█████╗  ██████╔╝██║  ███╗██║██║   ██║      
    ╚════██║██╔══╝  ██╔══██╗██║   ██║██║██║   ██║      
    ███████║███████╗██║  ██║╚██████╔╝██║╚██████╔╝      
    ╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝ ╚═════╝       
 █████╗ ███╗   ██╗████████╗ ██████╗ ███████╗███████╗██╗
██╔══██╗████╗  ██║╚══██╔══╝██╔═══██╗╚══███╔╝╚══███╔╝██║
███████║██╔██╗ ██║   ██║   ██║   ██║  ███╔╝   ███╔╝ ██║
██╔══██║██║╚██╗██║   ██║   ██║   ██║ ███╔╝   ███╔╝  ██║
██║  ██║██║ ╚████║   ██║   ╚██████╔╝███████╗███████╗██║
╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚══════╝╚══════╝╚═╝
                                                       

";
          
            Console.ForegroundColor = ConsoleColor.Blue;
         
            Console.WriteLine(firma);
            Console.ReadLine();
        
        }
       
    }
}


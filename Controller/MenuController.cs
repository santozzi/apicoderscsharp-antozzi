using ProyectoFinal_Antozzi.Services;
using ProyectoFinal_Antozzi.View;
using System;


namespace ProyectoFinal_Antozzi.Controller
{
    internal abstract class MenuController
    {
        protected Menu menu;
        protected UsuarioServices usuarioServices;
        protected ProductoServices productoServices;
        protected ProductoVendidoServices productoVendidoServices;
        protected VentaServices ventaServices;



        protected  int ShowMenu() {
            Console.Clear();
           return  menu.ShowMenu();
        
        }
        
       
        protected void Salir() {
        Console.Clear ();
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
            Console.WriteLine("Exit!!! BYE BYE!! ");
            Console.WriteLine(firma);
            Console.ReadLine();
        
        }
       
    }
}


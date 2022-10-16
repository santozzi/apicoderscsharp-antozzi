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


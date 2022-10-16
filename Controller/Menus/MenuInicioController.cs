using ProyectoFinal_Antozzi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Controller
{
    internal class MenuInicioController : MenuController
    {
        protected List<String> menuOptions;
        public MenuInicioController() { 
         
            this.menuOptions = new List<String>();
            menuOptions.Add("Iniciar sesión");
            menuOptions.Add("Crear un usuario nuevo");
            menuOptions.Add("Salir");
         
            this.menu = new Menu("Usuario", menuOptions);
            Opcion();
    }
   
        private  void Opcion()
        {
            int opcion = this.ShowMenu();
            if (opcion == 0)
            {
                IniciarSesion();
                //ShowMenu();
            }
            else if (opcion == 1)
            {
                CrearNuevoUsuario();
               // ShowMenu();
            }
            else 
            {
                this.Salir();
            }
            Console.ReadKey();
        }

        private void IniciarSesion(int cant=1) {
            string usuario= string.Empty;
            string clave = string.Empty;
            
            Console.Clear();
            Console.Write("Ingrese nombre de Usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese contraseña: ");
            clave = Console.ReadLine(); 
            Console.WriteLine();
            if (VerificarUsuarioYContraseña(usuario, clave))
            {
                Console.WriteLine("Correcto");
            }
            else {
                Console.WriteLine("Usuario y/o clave incorrectos");
                Console.ReadKey();
                if (cant < 3)
                {
                    IniciarSesion(++cant);
                }
                else { 
                    this.Salir();
                }

            }
        }
        private bool VerificarUsuarioYContraseña(string usuario, string contraseña) {
            bool usuarioYContraseña = false;


            return usuarioYContraseña;
        }


        private void CrearNuevoUsuario()
        {
            Console.WriteLine("Crear nuevo usuario");
        }
        
      



    }
}

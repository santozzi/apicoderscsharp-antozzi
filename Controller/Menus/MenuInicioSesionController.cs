using ProyectoFinal_Antozzi.Controller.Menus;
using ProyectoFinal_Antozzi.Services;
using ProyectoFinal_Antozzi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Controller
{
    internal class MenuInicioSesionController : MenuController
    {
        protected int count = 1;
        protected List<String> menuOptions;
        public MenuInicioSesionController()
        {

            this.menuOptions = new List<String>();
            menuOptions.Add("Iniciar sesión");
            // menuOptions.Add("Crear un usuario nuevo");
            menuOptions.Add("Salir");
            this.menu = new Menu("Usuario", menuOptions);
            ShowMenu();
        }

        private void ShowMenu()
        {
            Console.Clear();

            int opcion = menu.ShowMenu();
            if (opcion == 0)
            {
                IniciarSesion();
                //ShowMenu();
            }
            else if (opcion == 1)
            {
                //TODO: Crear usuario
                // ShowMenu();
            }
            else
            {

                //ShowMenu();
            }
            Console.ReadKey();
        }
        private void IniciarSesion()
        {
            Console.Clear();
            Console.Write("Ingresar el nombre de usuario: ");
            string userName = Console.ReadLine();
            // Console.WriteLine();
            Console.Write("Ingrese la contraseña: ");
            //Console.CursorVisible = false;
            //Console.hide
            string password = LeerPassword();
            this.count++;
            if (this.count <= 3)
            {
                if (IsUserAndPass(userName, password))
                {
                    new MenuTestController();
                }
                else
                {
                    IniciarSesion();
                }
            }
            else {

                Salir();
            }
        }
        private bool IsUserAndPass(string user, string password) {
            UsuarioServices us = new UsuarioServices();
            return us.IsUsernameAndPassword(user,password).Id!=0;
        }


        /*
         Obtenido de: https://social.msdn.microsoft.com/Forums/es-ES/9c53b610-54bb-44e6-b9b6-fb9b5e5e2656/poner-en-una-contrasea?forum=vcses
         */
        public static string LeerPassword()
        {
            ConsoleKeyInfo cki;
            StringBuilder sb = new StringBuilder();

            do
            {
                cki = Console.ReadKey(true);
              
                if (cki.Key != ConsoleKey.Enter)
                {
                    sb.Append(cki.KeyChar);
                    Console.Write("*");
                }

                else
                    break;

            } while (true);
            Console.WriteLine();
            return sb.ToString();
        }
    }

}

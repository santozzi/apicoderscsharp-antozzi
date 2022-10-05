using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.View
{
    internal class Menu
    {
        protected string _title;
        protected List<string> _opcionesMenu;
        protected int _mayor;
        protected int halfDisplay;
        public int X { get; set; }
        public int Y { get; set; }
        protected ConsoleColor _selectedTextColor;
        protected ConsoleColor _selectedBackgroundColor;
        protected ConsoleColor _textColor;
        protected ConsoleColor _backgroundColor;
        protected bool _loop;
        protected ConsoleKeyInfo _tecla;
        
        
        
        public Menu() {
            this._selectedTextColor = ConsoleColor.White;
            this._selectedBackgroundColor = ConsoleColor.Blue;
            this._textColor = ConsoleColor.Gray;
            this._backgroundColor = ConsoleColor.Black;
            this._loop = true;
        }
        public Menu(string title,List<string> opcionesMenu) {
            this._title = title;
            this._opcionesMenu = opcionesMenu;
            foreach (string opcion in opcionesMenu)
            {
                if (opcion.Length > this._mayor) { 
                  this._mayor = opcion.Length;
                }

            }
            this.halfDisplay = (Console.WindowWidth / 2) - this._mayor / 2;
            this._selectedTextColor= ConsoleColor.Black;
            this._selectedBackgroundColor= ConsoleColor.Cyan;
            this._textColor= ConsoleColor.Gray;
            this._backgroundColor = ConsoleColor.Black;
            Y = 5;
            Console.CursorTop = Y;
            //Console.CursorLeft = 10;
        }

        private string GenSpace(int cant,char caracter) {
            string space = "";
            for (int i = 0; i < cant; i++) {
                space += caracter; 
            }

            return space;
        }
        private void CentrarDisplay(List<string> options) {
            int paddingLeft = 2;
            int paddingRight = 2;
            string strPadLeft = GenSpace(paddingLeft,' ');
            string strPadRight = GenSpace(paddingRight, ' '); ;
            int mayor = 0;
            int indiceDelMayor = 0;
            for (int i = 0; i < options.Count; i++)
            {
                if (options[i].Length > mayor)
                {
                    mayor = options[i].Length;
                    indiceDelMayor = i;
                }
            }
            options[indiceDelMayor] = strPadLeft + options[indiceDelMayor] + strPadRight;
            mayor += paddingLeft + paddingRight;

            for (int i = 0; i<options.Count;i++)
            {
                if (i != indiceDelMayor) {
                    int padding = (mayor - options[i].Length) /2;
                    string space = GenSpace(padding, ' ');
                    options[i] = space+options[i]+space;
                }
               
               
            }
          
        }
        public int ShowMenu(string title,List<string> options) 
        {
            //CentrarDisplay(options);
            Console.CursorVisible = false;
            Console.CursorLeft = halfDisplay;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
           // Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(title);
            Console.WriteLine();
            
            
            this.X = halfDisplay;
            this.Y = Console.CursorTop;
            int counter=0;
            string resultado = MenuOp(options, counter);
          
              while((this._tecla= Console.ReadKey(true)).Key != ConsoleKey.Enter) {
                    switch (_tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (counter >= options.Count -1 )
                            {
                                counter=0;
                            }else
                                counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (counter <= 0) {
                                counter= options.Count -1;
                            }else
                              counter--;
                            break;
                            default:
                            break;
                    }
                    //Console.CursorLeft = this.halfDisplay;
                    //Console.CursorTop = Y;

                     MenuOp(options, counter);
                    
              }
       
            return counter;
        }



        public int ShowMenu()
        {
            //CentrarDisplay(options);
            Console.CursorVisible = false;
           // Console.CursorLeft = halfDisplay;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(this._title);
            Console.WriteLine();


            //this.X = halfDisplay;
            //this.Y = Console.CursorTop;
            int counter = 0;
            string resultado = MenuOp(_opcionesMenu, counter);

            while ((this._tecla = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                switch (_tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (counter >= _opcionesMenu.Count - 1)
                        {
                            counter = 0;
                        }
                        else
                            counter++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (counter <= 0)
                        {
                            counter = _opcionesMenu.Count - 1;
                        }
                        else
                            counter--;
                        break;
                    default:
                        break;
                }
                //Console.CursorLeft = this.halfDisplay;
                //Console.CursorTop = Y;

                MenuOp(_opcionesMenu, counter);

            }

            return counter;
        }



        //Establece el color y la ubicacion del menu
        private string MenuOp(List<string> items, int opcion) {
            string SeleccionActual = string.Empty;
            int destacado = 0;
            Console.CursorTop = Y;
            
            foreach (string element in items)
            {
                Console.CursorLeft = X;

                if (destacado == opcion)
                {
                    Console.ForegroundColor = this._selectedTextColor;
                    Console.BackgroundColor = this._selectedBackgroundColor;
                    SeleccionActual = element;
                }
               
                Console.WriteLine(element);
                Console.ForegroundColor = this._textColor;
                Console.BackgroundColor = this._backgroundColor;
                destacado++;
            }
            return SeleccionActual;
        }


    }
}

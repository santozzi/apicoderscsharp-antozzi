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
           new MenuInicioSesionController();
        }
    }
}

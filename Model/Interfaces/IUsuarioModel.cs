using ProyectoFinal_Antozzi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.Interfaces
{
    internal interface IUsuarioModel: ICRUD<Usuario>
    { 
        /// <summary>
        ///    Devuelve un usuario cuyo nombre de usuario es NombreUsuario,
        ///    de no exister devuelve null
        /// </summary>
        Usuario GetByNombreUsuario(string nombreUsuario);

        /// <summary>
        ///    Devuelve un usuario cuyo nombre de usuario es username y su constraseña es password,
        ///    de no existir el usuario o de no coincidir la contraseña con password el usuario se devuelve vacio con id= 0
        /// </summary>
        Usuario IsUsernameAndPassword(string username, string password);

        /// <summary>
        /// Devuelve en Id de ingresando un nombre de usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns>Id del Usuario si existe y 0 de lo contrario</returns>
        Int64 GetIdByNombreUsuario(string nombreUsuario);

    }
}

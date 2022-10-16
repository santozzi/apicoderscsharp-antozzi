using ProyectoFinal_Antozzi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.Interfaces
{
    internal interface IProductoModel : ICRUD<Producto>
    {
        /// <summary>
        ///    Se ingresa por parametro el Id del usuario y devuelve la 
        ///    lista con productos comprados por el usuario
        /// </summary>
        List<Producto> GetByIdUsuario(int id);
       
    }
}

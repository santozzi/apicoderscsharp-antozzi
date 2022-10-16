using ProyectoFinal_Antozzi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.Interfaces
{
    internal interface IVentaModel: ICRUD<Venta>
    {
        /// <summary>
        ///    Elimina la venta por el id de ususario y todas sus dependencias, devuelve true si el id existe y false de lo contrario.
        /// </summary>
        bool DeleteByIdUser(int id);

        /// <summary>
        ///    Devuelve una lista de ventas segun IdUsuario
        /// </summary>
        List<Venta> GetVentasByIdUsuer(int idUsuario);
    }
}

using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;
using ProyectoFinal_Antozzi.Model.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Services
{
    internal class VentaServices
    {
        protected IVentaModel _ventaModel;
        public VentaServices() {
            _ventaModel = new VentaModel();
        }

        public List<Venta> GetVentasByIdUsuer(int idUsuario) { 
         return _ventaModel.GetVentasByIdUsuer(idUsuario);
        }
    }
}

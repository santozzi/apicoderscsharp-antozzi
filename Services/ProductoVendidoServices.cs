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
    internal class ProductoVendidoServices
    {
        IProductoVendido _productoVendido;
        public ProductoVendidoServices() {
            _productoVendido = new ProductoVendidoModel();
        }

        public List<Producto> GetByUserName(string userName) {
           return _productoVendido.GetByUserName(userName);
        }
    }
}

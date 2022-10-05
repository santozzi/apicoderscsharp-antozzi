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
    internal class ProductoServices : IProductoModel
    {
        protected IProductoModel _productoModel;
        public ProductoServices() {
            _productoModel = new ProductoModel();


        }
        public Producto Add(Producto entity)
        {
            return _productoModel.Add(entity);
        }

        public Producto Delete(int id)
        {
            return this._productoModel.Delete(id);
        }

        public Producto Get(int id)
        {
            return _productoModel.Get(id);
        }

        public List<Producto> GetAll()
        {
            return _productoModel.GetAll();

        }

        public Producto Update(Producto entity, int id)
        {
            return _productoModel.Update(entity,id);
        }
    }
}

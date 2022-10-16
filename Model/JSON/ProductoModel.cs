using Newtonsoft.Json;
using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.JSON
{
    internal class ProductoModel : IProductoModel
    {
        private List<Producto> _products;

        private string _path;
        private Int64 _count;

        public ProductoModel() {
          //string _path1 = @"C:\Users\Sergio\Documents\cursos\coder house\csharp\ProyectoFinal-Antozzi\ProyectoFinal-Antozzi\Model\JSON\DB\productosJson.json";
          //se encuentra en bin/debug
          string _path2 = Path.GetFullPath("./DB/productosJson.json");
          this._count = 1;
          this._path = _path2;
           
            if (!File.Exists(_path))
            {
                this._products = new List<Producto>();
                //string productsJson = JsonConvert.SerializeObject(_products.ToArray(), Formatting.Indented);
                using (FileStream fs = File.Create(_path)) { 
                    
                }
                
                SerializeJsonFile();
                //File.WriteAllText(_path, productsJson);

            }
            else 
            {
                _products = DeserializeJsonFile(GetProductsJsonFromFile());
            }



               
            if (_products.Count == 0)
            {
                this._count = 1;
            }
            else {
                this._count = _products.Last<Producto>().Id + 1;
            }

        }
        public Producto Add(Producto entity)
        {  
            entity.Id = this._count++;
           _products.Add(entity);
            SerializeJsonFile();
            return entity;
        }

        public Producto Delete(int id)
        {
            Producto producto = _products.Find(x => x.Id == id);
            Console.WriteLine(producto.Descripcion);
            _products.Remove(producto);
            SerializeJsonFile();

            return producto;
        }

        public Producto Get(int id)
        {
            return _products.Find(x => x.Id == id);
        }

        public List<Producto> GetAll()
        {
            
            return _products;
        }
       
        public Producto Update(Producto entity, int id)
        {
            Producto producto = _products.Find(x => x.Id == id);
            int indice = _products.IndexOf(producto);
            Console.WriteLine("Indice encontrado: "+indice);
            entity.Id = id;
            _products[indice] = entity;
            SerializeJsonFile();
            return null;
        }

        private void SerializeJsonFile()
        {
            string productsJson = JsonConvert.SerializeObject(_products.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, productsJson);
        }
        private string GetProductsJsonFromFile()
        {
            string productsJsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                productsJsonFromFile = reader.ReadToEnd();


            }
            return productsJsonFromFile;
        }
        private List<Producto> DeserializeJsonFile(string products)
        {
            var prods = JsonConvert.DeserializeObject<List<Producto>>(products);
            return prods;
        }

        Producto ICRUD<Producto>.
            Add(Producto entity)
        {
            throw new NotImplementedException();
        }

        bool ICRUD<Producto>.Update(Producto entity, int id)
        {
            throw new NotImplementedException();
        }

        bool ICRUD<Producto>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetByIdUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}

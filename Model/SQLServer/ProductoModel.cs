using Newtonsoft.Json.Linq;
using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.SQLServer
{
    internal class ProductoModel : IProductoModel
    {

        private string _connectionString;

        public ProductoModel()
        {
            _connectionString = "Server=localhost;" +
                                     "Database=SistemaGestion;" +
                                     "Trusted_Connection=True;";

        }
        public SqlDataReader ExecuteSql(string sql)
        {
            SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(1));
                }
                Console.ReadKey();
                connection.Close();

            }
            return reader;

        }




        public Producto Add(Producto entity)
        {
         
           
            string sql = $"INSERT INTO producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario ) VALUES ('{entity.Descripcion}', {entity.Costo},{entity.PrecioDeVenta},{entity.Stock}, {entity.IdUsuario})";


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {


                using (SqlCommand cmd = new SqlCommand(sql, connection)) { 


                connection.Open();
                
                    cmd.ExecuteReader();
                connection.Close();
            }
                }
            
            return entity;
        }

        public Producto Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Producto Get(int id)
        {
            Producto producto = null;
            string sql = $"SELECT * FROM producto WHERE id LIKE {id}";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto();
                    producto.Id = reader.GetInt64(0);
                    producto.Descripcion = reader.GetString(1);
                    producto.Costo = (double)reader.GetDecimal(2);
                    producto.PrecioDeVenta = (double)reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);
                   

                }

                connection.Close();

            }
            return producto;
        }

        public List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM producto";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                   Producto producto = new Producto();
                   producto.Id = reader.GetInt64(0);
                   producto.Descripcion= reader.GetString(1);
                   producto.Costo = (double)reader.GetDecimal(2);
                   producto.PrecioDeVenta = (double)reader.GetDecimal(3);
                   producto.Stock = reader.GetInt32(4);
                   producto.IdUsuario = reader.GetInt64(5);
                   productos.Add(producto);
                 
                }
                connection.Close();

            }
            return productos;
        }

        public Producto Update(Producto entity, int id)
        {
            Producto producto = Get(id);
            string sql = $"UPDATE producto" +
                         $"SET " +
                         $"Descripciones = {entity.Descripcion}," +
                         $"Costo = {entity.Costo}," +
                         $"PrecioVenta = {entity.PrecioDeVenta}," +
                         $"Stock = {entity.Stock} " +
                         $"WHERE Id like {id}";
            if (producto != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();


                    connection.Close();

                }
            }
            return producto;
        }
    }
}

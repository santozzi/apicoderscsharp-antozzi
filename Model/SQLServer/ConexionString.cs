using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model.SQLServer
{
    internal abstract class ConexionString
    {
        protected string _connectionString = "Server=localhost;" +
                                     "Database=SistemaGestion;" +
                                     "Trusted_Connection=True;";
        
    }
}

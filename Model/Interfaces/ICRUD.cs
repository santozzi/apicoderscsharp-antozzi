using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Model
{
    internal interface ICRUD <T>
    {
        T Add(T entity);
        List<T> GetAll();
        T Get(int id);
        bool Update(T entity, int id); 
        bool Delete(int id);
        
    }
}

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
        T Update(T entity, int id); 
        T Delete(int id);
        
    }
}

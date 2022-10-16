using ProyectoFinal_Antozzi.Entities;
using ProyectoFinal_Antozzi.Model.Interfaces;
using ProyectoFinal_Antozzi.Model.SQLServer;
using System.Collections.Generic;


namespace ProyectoFinal_Antozzi.Services
{
    internal class UsuarioServices
    {
        IUsuarioModel _usuarioModel;
        public UsuarioServices() {
            _usuarioModel = new UsuarioModel();

        }

        public Usuario IsUsernameAndPassword(string userName, string password) { 
         return _usuarioModel.IsUsernameAndPassword(userName, password);
        }

        public List<Usuario> GetAll() {
         return _usuarioModel.GetAll();
        }

        public Usuario GetByNombreUsuario(string nombreUsuario) { 
          return _usuarioModel.GetByNombreUsuario(nombreUsuario);
        }
        public long GetIdByNombreUsuario(string nombreUsuario) {
            return _usuarioModel.GetIdByNombreUsuario(nombreUsuario);
        }



    }
}

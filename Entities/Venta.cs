﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Antozzi.Entities
{
    internal class Venta
    {
        protected Int64 _id;
        //pongo comentarios por lo que dice en el pdf, yo supongo que debe ir en singular, a menos que sea un array o lista
        protected string _comentarios;
        protected Int64 _idUsuario;
        public Venta(string comentarios,Int64 idUsuario) {
            _idUsuario = idUsuario;
            _comentarios = comentarios;
        }
        public Venta() { }
        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value; }
        }
        public Int64 IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public override string ToString()
        {
            return $"id: {_id} - comentarios: {_comentarios} - idUsuario: {_idUsuario}";
        }
    }
}

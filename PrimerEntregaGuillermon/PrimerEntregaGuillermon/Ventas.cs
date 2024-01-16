using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntregaGuillermon
{
    public class Ventas
    {

        int _Id;
        string _Comentarios;
        int _IdUsuario;

        public Ventas() { }

        public Ventas(int id, string comentarios, int idUsuario)
        {

            this._Id = id;
            this._Comentarios = comentarios;
            this._IdUsuario = idUsuario;  
          
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Comentarios { get { return _Comentarios; } set { _Comentarios = value; } }
        public int IdUsuario { get { return _IdUsuario; } set { _IdUsuario = value; } }
    }
}

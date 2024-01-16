using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntregaGuillermon
{
    public class Usuario
    {
        int _Id;
        string _Nombre;
        string _Apellido;
        string _NombreUsuario;
        string _Contraseña;
        string _Mail;

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail) 
        {

            this._Id = id;
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._NombreUsuario = nombreUsuario;
            this._Contraseña = contraseña;
            this._Mail = mail;
        
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string Apellido { get { return _Apellido; } set { _Apellido = value; } }
        public string NombreUsuario { get { return _NombreUsuario; } set { _NombreUsuario = value; } }
        public string Contraseña { get { return _Contraseña; } set { _Contraseña = value; } }
        public string Mail { get { return _Mail; } set { _Mail = value; } }

    }
}

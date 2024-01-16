using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntregaGuillermon
{
    public class Producto
    {

        int _Id;
        string _Descripcion;
        double _Costo;
        double _PrecioVenta;
        int _Stock;
        int _IdUsuario;

        public Producto() { }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {

            this._Id = id;
            this._Descripcion = descripcion;
            this._Costo = costo;
            this._PrecioVenta = precioVenta;
            this._Stock = stock;
            this._IdUsuario = idUsuario;  

        }

        public int Id { get { return _Id;} set { _Id = value; } }
        public string Descripcion { get { return _Descripcion; } set { _Descripcion = value; } }
        public double Costo { get { return _Costo; } set { _Costo = value; } }
        public double PrecioVenta { get { return _PrecioVenta; } set { _PrecioVenta = value; } }
        public int Stock { get { return _Stock; }  }
        public int IdUsuario { get { return _IdUsuario; } set { _IdUsuario = value; } }

    }
}

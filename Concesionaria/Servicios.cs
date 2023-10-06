using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Servicios
    {
        private string _Titulo;
        private string _Detalle;
        private List<Postventa> _Postventa;
        private double _Precio;

        //constructor
        public Servicios()
        {
            this.Titulo = "";
            this.Detalle = "";
            this.Precio = 0;
        }

        public string Titulo
        {
            get { return this._Titulo; }
            set { this._Titulo = value;}
        }
        public string Detalle
        {
            get { return this._Detalle; }
            set { this._Detalle = value; }
        }
        public double Precio
        {
            get { return this._Precio; }
            set { this._Precio = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Vehiculos
    {
        private string _Dominio;
        private string _Anio;
        private Modelo _Modelo;
        //marca
        private string _Color;
        private double _PrecioLista;
        private Venta _Venta;

        //constructor
        public Vehiculos()
        {
            this.Dominio = "";
            this.Anio = "";
            this.Color = "";
            this.PrecioLista = 0;
        }

        public string Dominio
        {
            get { return this._Dominio; }
            set { this._Dominio = value;}
        }

        public string Anio
        {
            get { return this._Anio; }
            set { this._Anio = value;}
        }
        
        public string Color
        {
            get { return this._Color; }
            set { this._Color = value; }
        }

        public double PrecioLista
        {
            get { return this._PrecioLista;}
            set { this._PrecioLista = value;}
        }
    }
}

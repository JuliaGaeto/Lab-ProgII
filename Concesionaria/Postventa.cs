using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Postventa
    {
        private DateTime _Fecha;
        private List<Servicios> _Servicios;
        private string _Observaciones;
        private Venta _Venta;

        //constructor
        public Postventa()
        {
            this.Fecha = DateTime.Now;
            this.Observaciones = "";
        }

        public DateTime Fecha
        {
            get { return this._Fecha; }
            set { this._Fecha = value; }
        }
        public string Observaciones
        {
            get { return this._Observaciones; }
            set { this._Observaciones = value; }
        }
    }
}

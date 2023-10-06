using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Venta
    {
        private DateTime _Fecha;
        private Cliente _Cliente;
        private string _Comentario;
        private Vehiculos _Vehiculo;
        private List<Postventa> _Postventa;

        //constructor

        public DateTime Fecha
        {
            get { return this._Fecha; }
            set { this._Fecha = value; }
        }

        public string Comentario
        {
            get { return this._Comentario; }
            set { this.Comentario = value; }
        }
    }
}

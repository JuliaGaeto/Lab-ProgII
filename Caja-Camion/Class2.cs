using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Camion
{
    internal class Class2
    {
        //3 propiedades: 2 L/E, 1 L.
        private string _trabajador;
        private int _bono;
        private float _sueldo;

        public string Trabajador
        {
            get { return this._trabajador; }
            set { this._trabajador = value; }
        }
        public int Bono
        {
            get { return this._bono; }
            set { this._bono = value; }
        }
        public float Sueldo
        {
            get { return this._sueldo; }
            set { this._sueldo = value; }
        }
        public float Total
        {
            get { return this.Bono + this.Sueldo; }
        }
    }
}

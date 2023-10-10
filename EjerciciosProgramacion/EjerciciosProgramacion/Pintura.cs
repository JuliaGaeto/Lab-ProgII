using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    internal class Pintura : Articulo
    {
        //es_lavable, capacidad_cobertura, es_secado_rapido, es_latex
        private double _CapCobertura;
        private bool _Lavable;
        private bool _SecadoRapido;
        private bool _Latex;
        //constructor
        public Pintura()
        {
            this.Descripcion = "-";
            this.Marca = "-";
            this.CodBarra = "-";
            this.Precio = 0;
            this.Costo = 0;
            this.Stock = 0;

            this.CapCobertura = 0;
            this.Lavable = false;
            this.SecadoRapido = false;
            this.Latex = false;
        }

        public double CapCobertura
        {
            get { return this._CapCobertura;}
            set { this._CapCobertura = value; }
        }
        public bool Lavable
        {
            get { return this._Lavable; }
            set { this._Lavable = value; }
        }
        public bool SecadoRapido
        {
            get { return this._SecadoRapido; }
            set { this._SecadoRapido = value; }
        }
        public bool Latex
        {
            get { return this._Latex; }
            set { this._Latex = value; }
        }
    }
}

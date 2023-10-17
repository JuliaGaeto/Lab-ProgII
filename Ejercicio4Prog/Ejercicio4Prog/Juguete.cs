using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Prog
{
    abstract internal class Juguete
    {
        private double _Precio;
        private float _PorImp;
        private string _Marca;
        private string _Modelo;

        public double Precio
        {
            get { return this._Precio; }
            set { this._Precio = value; }
        }
        public float PorcentajeImpuestos
        {
            get { return this._PorImp; }
            set { this._PorImp = value; }
        }
        public string Marca
        {
            get { return this._Marca; }
            set { this._Marca = value; }
        }
        public string Modelo
        {
            get { return this._Modelo; }
            set { this._Modelo = value; }
        }
        public abstract int AptoMayoresDe
        {
            get;
        }
        public abstract string Descripcion
        {
            get;
        }

        //metodo abstracto(si o si tiene que estar en la clase hija)(este metodo solo se implementa en clases abstractas)

        //metodo virtual(si establecen datos por default y no es necesario que este en las clases hijas)(para implementarlo no es necesario que la clase sea abstracta)
    }
}

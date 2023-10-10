using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    internal class Herramienta_Inalambrica : Articulo
    {
        //voltaje, modelo, incluye_bateria, encender, apagar, 
        private double _Voltaje;
        private string _Modelo;
        private bool _IncluyeBat;

        public Herramienta_Inalambrica() //constructor
        {
            this.Descripcion = "-";
            this.Marca = "-";
            this.CodBarra = "-";
            this.Precio = 0;
            this.Costo = 0;
            this.Stock = 0;
            this.Voltaje = 0;
            this.Modelo = "-";
        }

        public double Voltaje
        {
            get { return this._Voltaje; } set { this._Voltaje = value; }
        }

        public string Modelo
        {
            get { return this._Modelo; } set { this._Modelo = value; }
        }
        public bool IncluyeBateria
        {
            get { return this._IncluyeBat; }
            set { this._IncluyeBat = value; }
        }
        //metodos
        public bool Encender()
        {
            return false;
        }
        public bool Apagar()
        {
            return false;
        }
    }
}

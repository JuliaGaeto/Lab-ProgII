using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Cliente
    {
        private string _CUIT;
        private string _Apellidos;
        private string _Nombre;
        private string _Direccion;
        private Ciudades _Ciudad;
        private int _Telefono;
        private List<Venta> _Ventas;

        //constructor
        public Cliente()
        {
            this.CIUT = "";
            this.Apellido = "";
            this.Nombre = "";
            this.Direccion = "";
            this.Telefono = 0;
        }

        public string CIUT
        {
            get { return this._CUIT; }
            set { this._CUIT = value; }
        }
        public string Apellido
        {
            get { return this._Apellidos; }
            set { this._Apellidos = value; }
        }
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value;}
        }
        public string Direccion
        {
            get { return this._Direccion;}
            set { this._Direccion = value;}
        }
        public int Telefono
        {
            get { return this._Telefono;}
            set { this._Telefono = value;}
        }
    }
}

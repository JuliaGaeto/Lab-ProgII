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
        public Pintura(string descripcion, string marca, string modelo, string codbarra, double precio, double costo, int stock, double capcobertura, bool lavable, bool secadorap, bool latex)
        {
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Modelo = modelo;
            this.CodBarra = codbarra;
            this.Precio = precio;
            this.Costo = costo;
            this.Stock = stock;

            this.CapCobertura = capcobertura;
            this.Lavable = lavable;
            this.SecadoRapido = secadorap;
            this.Latex = latex;
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

        public override void Info()
        {
            Console.WriteLine("Tipo: artículo");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Código de barra: {CodBarra}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Costo: {Costo}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Capacidad de cobertura: {CapCobertura}");
            Console.WriteLine($"Es lavable?: {Lavable}");
            Console.WriteLine($"Es de secado rápido?: {SecadoRapido}");
            Console.WriteLine($"Es latex?: {Latex}");
        }
    }
}

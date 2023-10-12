using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    abstract class Articulo
    {
        //descripcion, marca, codigobarra, precio, costo, stock
        private string _Descripcion;
        private string _Marca;
        private string _Modelo;
        private string _CodBarra;
        private double _Precio;
        private double _Costo;
        private int _Stock;
        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }
        public string Marca
        {
            get { return this._Marca; } set { this._Marca = value; }
        }

        public string Modelo
        {
            get { return this._Modelo; }
            set { this._Modelo = value; }
        }
        public string CodBarra
        {
            get { return this._CodBarra; }
            set { this._CodBarra = value; }
        }
        public double Precio
        {
            get { return this._Precio; }
            set { this._Precio = value; }
        }
        public double Costo
        {
            get { return this._Costo; }
            set { this._Costo = value; }
        }
        public int Stock
        {
            get { return this._Stock; }
            set { this._Stock = value; }
        }

        public virtual void Info()
        {
            Console.WriteLine("Tipo: artículo");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Código de barra: {CodBarra}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Costo: {Costo}");
            Console.WriteLine($"Stock: {Stock}");
        }
    }
}

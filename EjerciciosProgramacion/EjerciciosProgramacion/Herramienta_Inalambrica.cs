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

        public Herramienta_Inalambrica(string descripcion, string marca, string modelo, string codbarra, double precio, double costo, int stock, double voltaje, bool incluyebat) //constructor
        {
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Modelo = modelo;
            this.CodBarra = codbarra;
            this.Precio = precio;
            this.Costo = costo;
            this.Stock = stock;
            this.Voltaje = voltaje;
            this.IncluyeBateria = incluyebat;
        }

        public double Voltaje
        {
            get { return this._Voltaje; } set { this._Voltaje = value; }
        }

        public bool IncluyeBateria
        {
            get { return this._IncluyeBat; }
            set { this._IncluyeBat = value; }
        }
        //metodos
        public bool Encender(bool encendido)
        {
            if(encendido == true)
            {
                return true;
            }
            return false;
        }
        public bool Apagar(bool apagado)
        {
            if(apagado == true)
            {
                return true;
            }
            return false;
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
            Console.WriteLine($"Voltaje: {Voltaje}");
            Console.WriteLine($"Incluye batería: {IncluyeBateria}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Rectangulo : Figura
    {
        private int _LadoA;
        private int _LadoB;

        //constructor
        public Rectangulo()
        {
            this.Color = "Blanco";
            this.LadoA = 0;
            this.LadoB = 0;
        }

        public override int CantLados
        {
            get
            {
                return 4;
            }
        }

        public override int Perimetro
        {
            get
            {
                return (this.LadoA * 2) + (this.LadoB * 2);
            }
        }

        public override void Info()
        {
            Console.WriteLine($"\n\nInfo rectángulo: Color {this.Color}|Cantidad de lados {this.CantLados}|Perímetro {this.Perimetro}|LadoA {this.LadoA}|LadoB {this.LadoB}");
        }

        public int LadoA
        {
            get
            {
                return this._LadoA;
            }
            set
            {
                this._LadoA = value;
            }
        }

        public int LadoB
        {
            get
            {
                return this._LadoB;
            }
            set
            {
                this._LadoB = value;
            }
        }
    }
}

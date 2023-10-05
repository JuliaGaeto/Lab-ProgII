using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Triangulo : Figura
    {
        private int _LadoA;
        private int _LadoB;
        private int _LadoC;

        //constructor
        public Triangulo()
        {
            this.Color = "Blanco";
            this.LadoA = 0;
            this.LadoB = 0;
            this.LadoC = 0;
        }

        public override int CantLados
        {
            get
            {
                return 3;
            }
        }

        public override int Perimetro
        {
            get
            {
                return this.LadoA + this.LadoB + this.LadoC;
            }
        }

        public override void Info()
        {
            Console.WriteLine($"\n\nInfo triángulo: Color {this.Color}|Cantidad de lados {this.CantLados}|Perímetro {this.Perimetro}|LadoA {this.LadoA}|LadoB {this.LadoB}|LadoC {this.LadoC}");
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

        public int LadoC
        {
            get
            {
                return this._LadoC;
            }
            set
            {
                this._LadoC = value;
            }
        }
    }
}

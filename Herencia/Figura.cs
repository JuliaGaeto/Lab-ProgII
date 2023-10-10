using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Figura //clase abstracta, no se puede crear un objeto de clase figura
    {
        private string _privColor;

        public string Color
        {
            get
            {
                return this._privColor;
            }
            set
            {
                this._privColor = value;
            }
        }

        public abstract int CantLados
        {
            get;
        }

        public abstract int Perimetro
        {
            get;
        }

        public abstract void Info();

        //método
        public virtual void InfoCompleta()
        {
            Console.WriteLine("Tipo: Figura");
            Console.WriteLine($"Perímetro: {Perimetro}");
            Console.WriteLine($"Cantidad de lados: {CantLados}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Figura
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Lab
{
    internal class Jugador
    {
        private string _Nombre;
        private string _Color;
        public int _Puntaje;

        //constructor
        public Jugador()
        {
            this.Nombre = "";
            this.Color = "";
            this.Puntaje = 0;
        }
        public Jugador(string N_Nombre, string N_Color)
        {
            this.Nombre = N_Nombre;
            this.Color = N_Color;
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }
        public int Puntaje
        {
            get
            {
                return _Puntaje;
            }
            set
            {
                _Puntaje = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Lab
{
    internal class Fichas
    {
        private string _Color;
        private string _Movimiento;
        private string _Tipo; //Ej: ajedrez o backgammon
        private string _Seleccionado;

        //constructor
        public Fichas()
        {
            this.Color = "";
            this.Movimiento = "";
            this.Tipo = "";
            this.Seleccionado = "";
        }
        //constructor
        public Fichas(string N_Color, string N_Movimiento, string N_Tipo, string N_Seleccionado)
        {
            this.Color = N_Color;
            this.Movimiento = N_Movimiento;
            this.Tipo = N_Tipo;
            this.Seleccionado = N_Seleccionado;
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
        public string Movimiento
        {
            get
            {
                return _Movimiento;
            }
            set
            {
                _Movimiento = value;
            }
        }
        private string Tipo
        {
            get
            {
                return _Tipo;
            }
            set
            {
                Tipo = value;
            }
        }
        private string Seleccionado
        {
            get
            {
                return _Seleccionado;
            }
            set
            {
                Seleccionado = value;
            }
        }
    }
}

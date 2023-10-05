using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Libreria
{
    internal class ClaseLibro
    {
        //propiedades privadas siempre con _ adelante
        private string _privSaga; //Ejemplo: Harry Potter
        private string _privTitulo; //Ejemplo: y la pedra filosofal
        private int _privTomo; //Ejemplo: 1
        private string _privGenero; //Ejemplo: Fanstástico
        private double _privAlto; //Para calcular el formato (de bolsillo o convencional)
        private double _privAncho; //Para calcular el formato
        //Agregar autor

        //constructor
        public ClaseLibro()
        {
            this.Saga = "";
            this.Titulo = "";
            this.Tomo = 0;
            this.Genero = "";
            this.Alto = 0;
            this.Ancho = 0;
        }

        //propiedades L/E
        public string Saga
        {
            get
            {
                return _privSaga + " ";
            }
            set
            {
                _privSaga = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _privTitulo;
            }
            set
            {
                _privTitulo = value;
            }
        }

        public int Tomo
        {
            get
            {
                return _privTomo;
            }
            set
            {
                _privTomo = value;
            }
        }

        public string Genero
        {
            get
            {
                return _privGenero;
            }
            set
            {
                _privGenero = value;
            }
        }

        public double Alto
        {
            get
            {
                return _privAlto;
            }
            set
            {
                _privAlto = value;
            }
        }

        public double Ancho
        {
            get
            {
                return _privAncho;
            }
            set
            {
                _privAncho = value;
            }
        }

        //propiedad S/L 
        public string Formato
        {
            get
            {
                if ((this.Ancho >= 11 && this.Ancho <= 15) && (this.Alto >= 17 && this.Alto <= 21))
                {
                    return "De Bolsillo";
                }
                else if ((this.Ancho >= 14.5 && this.Ancho <= 16) && (this.Alto >= 21 && this.Alto <= 24))
                {
                    return "Convencional";
                }
                else if (this.Ancho == 21 && this.Alto == 29.7)
                {
                    return "A4";
                }
                else
                {
                    return "No encontrado";
                }
            }
        }
        //de bolsillo: de 11x17 a 15x21
        //convencional: de 14.5x21 a 16x24
        //A4 (cómics/revistas/libros escolares): 21x29.7

        //destructor
    }
}

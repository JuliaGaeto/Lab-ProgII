using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Despacho
    {
        //generar una lista con todos los despachos realizados para luego al final del programa listarlos
        private Barco _barco;
        private Int32 _numDespacho;
        private Cliente _ClienteDeDespacho;
        private List<Despacho> _ListaDespachos;

        public Despacho()
        {
            this.Barco = Barco;
            this.NumeroDespacho = 0;
        }
    
        public Despacho(Barco barco, int codigo)
        {
            Barco = barco;
            NumeroDespacho = codigo;
        }

        public Barco Barco
        {
            get { return _barco; }
            set { _barco = value; }
        }

        public Int32 NumeroDespacho
        {
            get { return _numDespacho;}
            set { _numDespacho = value; }
        }
    }
}

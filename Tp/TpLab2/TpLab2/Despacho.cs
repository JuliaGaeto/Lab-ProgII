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
        private string _numDespacho;
        private Cliente _ClienteDeDespacho;
        //crear clase mercaderia. private List<Mercaderia> _Mercaderias
        //crear clase tarifa.
        //crear clase puerto. private Puerto _Destino. private Puerto _Origen
        private DateTime _Fecha;
        private double _Total;
        private string _Mercaderia;
        private DateTime _FechaSalida;
        private DateTime _FechaLlegada;
        public Despacho()
        {
            this.Barco = Barco;
            this.NumeroDespacho = "";
        }
    
        public Despacho(Barco barco, string codigo)
        {
            Barco = barco;
            NumeroDespacho = codigo;
        }

        public Barco Barco
        {
            get { return _barco; }
            set { _barco = value; }
        }

        public string NumeroDespacho
        {
            get { return _numDespacho;}
            set { _numDespacho = value; }
        }
    }
}

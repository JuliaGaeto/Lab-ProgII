using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public abstract class Cliente
    {
        private string _nombre;
        private string _codigo;
        private string _mercaderia;
        public Cliente()
        {
            NombreCliente = "";
            Mercaderia = "";
        }
        public string NombreCliente
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Mercaderia
        {
            get { return _mercaderia; }
            set { _mercaderia = value;}
        }
    }
}

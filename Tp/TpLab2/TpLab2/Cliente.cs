using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Cliente
    {
        private string _nombre;
        private string _codigo;
        private string _Mail;   
        private List<Despacho> _DespachosCliente;
        public Cliente()
        {
            NombreCliente = "";
            Codigo = "";
            this._DespachosCliente = new List<Despacho>();
        }

        public string NombreCliente
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value;}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Empleado
    {
        private string _NombreVendedor;
        private string _CodVendedor;

        //Constructor
        public Empleado(string nombvend, string codvend)
        {
            this.NombreVendedor = nombvend;
            this.CodVendedor = codvend;    
        }

        public string NombreVendedor
        {
            get { return this._NombreVendedor; }
            set { this._NombreVendedor = value; }
        }

        public string CodVendedor
        {
            get { return this._CodVendedor; }
            set { this._CodVendedor = value; }
        }

        //generar metodo que le muestre el porcentaje de comision por venta
    }
}

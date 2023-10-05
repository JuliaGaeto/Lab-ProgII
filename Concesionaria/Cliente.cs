using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Cliente
    {
        private string _CUIT;
        private string _Apellidos;
        private string _Nombre;
        private string _Direccion;
        private Ciudades _Ciudad;
        private int _Telefono;
        private List<Venta> _Ventas;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Constants
    {
        public const string FileNameCSV = "Clientes.csv";
        public const string FileNameCSVEmpleados = "EP_empleados.csv";
        public const string ClienteInexistenteErrorMessage = "El cliente ingresado no se encuentra en el sistema";
        public const string EmpleadoInexistenteErrorMessage = "El empleado ingresado no se encuentra en el sistema";
        public const string BarcoInexistenteErrorMessage = "El numero de barco ingresado es incorrecto o no se encuentra disponible";
        public const string ArchivoInexistenteMessage = "El archivo no existe";
        public const string CabeceraInexistente = "Cabecera vacía";


        public const string HeadTitle = "###   Empresa Portuaria  ###";
        public const string Divisor = ",";
        public static string[] menuOptions = { "Despachar", "Ver despachos realizados", "Salir" };
    }
}

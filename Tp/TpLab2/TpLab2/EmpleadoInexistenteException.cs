using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class EmpleadoInexistenteException : Exception
    {
        public EmpleadoInexistenteException() : base(Constants.EmpleadoInexistenteErrorMessage)
        {

        }
    }
}

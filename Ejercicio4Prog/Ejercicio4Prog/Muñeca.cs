using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Prog
{
    internal class Muñeca : Juguete
    {
        private string _ProfMuñeca;
        private bool _ContElementosAdicionales;
        private double _PrecioConImp;

        //constructor
        public Muñeca()
        {
            this.ProfesionMuñeca = "";
            this.ContElemAd = false;
            this.Precio = 0;
            this.Marca = "";
            this.Modelo = "";
        }
        //constructor con parametros
        public Muñeca(string PMuñeca, bool ElAd, double Pre, string Marc, string Mod)
        {
            this.ProfesionMuñeca = PMuñeca;
            this.ContElemAd = ElAd;
            this.Precio = Pre;
            this.Marca = Marc;
            this.Modelo = Mod;
        }

        public string ProfesionMuñeca
        {
            get { return this._ProfMuñeca; } set { this._ProfMuñeca = value; }
        }
        public bool ContElemAd
        {
            get { return this._ContElementosAdicionales; }
            set { this._ContElementosAdicionales = value; }
        }
        public double PrecioConImp
        {
            get
            {
                return this.Precio + (this.Precio * this.PorcentajeImpuestos);
            }
        }

        public override int AptoMayoresDe
        {
            get
            {
                return 7;
            }
        }
        public override string Descripcion
        {
            get
            {
                return "Muñeca";
            }
        }
    }
}

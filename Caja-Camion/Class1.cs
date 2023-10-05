using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Camion
{
    internal class Class1
    {
        private string _nombre; //propiedad del objeto, desde el main no voy a tener acceso
        private string _apellido; //propiedades del objeto

        //métodos constructores
        public Class1()
        {
            this.Apellido = "Perez";
            this.Nombre = "Lujan";
        }
        public Class1(string ape, string nom)
        {
            this.Apellido = ape;
            this.Nombre = nom;
        }

        public string Nombre //método de propiedad, desde el main voy a tener acceso; sirve para generar restricciones
        {
            get { return this._nombre; } //conocer el valor desde afuera que tiene una propiedad, si no tiene get es una prop de solo escritura
            set { this._nombre = value; } //asignarle un valor a la propiedad, si no está es una propiedad de solo lectura
        } //en este caso es de lectura/escritura
        public string Apellido //métodos de propiedades
        {
            get { return this._apellido; }
            set
            {
                if (value.Trim() != string.Empty) //para verificar que no se se quiere mostrar un espacio vacío
                {
                    this._apellido = value;
                }
            }
        }
        public string Apelnom //propiedad de solo lectura, se calcula a partir de otras propiedades
        {
            get { return this.Apellido + ", " + this.Nombre; }
        }
    }
}

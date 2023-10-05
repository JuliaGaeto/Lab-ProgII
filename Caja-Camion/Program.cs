using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Camion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Class1 A, B; //declarar el objeto, le aviso a la máquina que voy a trabajar con ese objeto
            A = new Class1(); //instanciar, me crea el objeto y le guarda espacio en memoria
            B = new Class1("Rosas", "Andrea");
            Console.WriteLine(A.Apelnom);
            A.Apellido = "Gomez";
            A.Nombre = "Lucas";
            Console.WriteLine(A.Apelnom);
            Console.WriteLine(B.Apelnom);
            */

            //ClaseCaja A;
            //A = new ClaseCaja(15, 15, 20);
            List<ClaseCaja> Deposito; //declarar lista
            Deposito = new List<ClaseCaja>(); //instanciar lista
            ClaseCaja A = new ClaseCaja(); //declarar e instanciar objeto
            ClaseCaja B = new ClaseCaja(); //declarar e instanciar objeto
            //Otra opción: ClaseCaja A = new ClaseCaja("AB345", "cartas", 15, 15, 20, 5, "cartón");
            A.CodigoInterno = "AB345";
            A.Contenido = "cartas";
            A.AltoCM = 15;
            A.LargoCM = 15;
            A.AnchoCM = 20;
            A.PesoKG = 5;
            A.Material = "cartón";
            Deposito.Add(A);

            B.CodigoInterno = "987M";
            B.Contenido = "piedras";
            B.AltoCM = 5;
            B.LargoCM = 5;
            B.AnchoCM = 10;
            B.PesoKG = 3;
            B.Material = "madera";
            Deposito.Add(B);
            //otra opción: deposito[0].Material = "cartón"; [0] hace referencia a A; si se agregara un nuevo objeto, ej B sería [1]

            //Cómo recorrer una lista:
            int pos = 0;
            float peso = 0;
            Console.WriteLine("Con for:");
            for (int i = 0; i < Deposito.Count(); i++)
            {
                if (peso < Deposito[i].PesoKG) //para solo mostrar la caja más pesada
                {
                    pos = i;
                    peso = Deposito[i].PesoKG;
                }
            }
            Console.WriteLine($"{Deposito[pos].CodigoInterno}|{Deposito[pos].Contenido}|{Deposito[pos].VolumenCM3}");
            //otra opción:
            Console.WriteLine("\nCon foreach:");
            foreach (ClaseCaja aux in Deposito) //recorre una colección de objetos; aux va a ir tomando los objetos en cada posición
            {
                Console.WriteLine($"{aux.CodigoInterno}|{aux.Contenido}|{aux.VolumenCM3}");
            }

            /*A.CodigoInterno = "12345";
            A.Contenido = "cartas";
            A.AltoCM = 15;
            A.LargoCM = 15;
            A.AnchoCM = 20;
            A.PesoKG = 5;
            A.Material = "cartón";*/
            //Console.WriteLine($"{A.CodigoInterno} {A.Contenido} {A.AltoCM} {A.LargoCM} {A.AnchoCM} {A.PesoKG} {A.Material} {A.VolumenCM3}");

            /*A.Trabajador = "Pepe"; //se usa el objeto
            A.Bono = 10000;
            A.Sueldo = 350500;
            Console.WriteLine(A.Trabajador);
            Console.WriteLine(A.Total);*/


            Console.WriteLine("\n\n");
            //clase camión
            ClaseCaja AUX = new ClaseCaja();
            ClaseCamion camionA = new ClaseCamion();
            camionA.Patente = "HFS-521";
            camionA.Chofer = "Gomez, Jorge";
            camionA.MaxCargaKG = 20;
            ClaseCaja a = new ClaseCaja("101", "manzanas", 10, 20, 5, 10, "madera");
            if (camionA.AgregarCaja(a) == true)
            {
                Console.WriteLine("caja agregada");
            }
            else
            {
                Console.WriteLine("caja excede peso disponible");
            }

            ClaseCaja b = new ClaseCaja("107", "cartas", 10, 20, 5, 5, "cartón");
            if (camionA.AgregarCaja(b) == true)
            {
                Console.WriteLine("caja agregada");
            }
            else
            {
                Console.WriteLine("caja excede peso disponible");
            }

            camionA.RecuperarDatosCaja(1, out AUX);
            Console.WriteLine(AUX.CodigoInterno);

            //camionA.RecuperarCajaPorCodigo(, out AUX);
            //Console.WriteLine(AUX.CodigoInterno);



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class DESPACHAR
    {
        public static void Run()
        {
            //EMPLEADO: ingresar nombre de empleado y corroborar que se encuentra en el sistema. Además por realizar un despacho, se le otorga una comisión
            //de un porcentaje del valor de dicho despacho.
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("-------------------- EMPLEADO --------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(ChequeoEmpleado());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            Console.ReadKey();

            //CLIENTE: se solicita ingresar el cliente para corroborar que éste se encuentre en el sistema, esto se hace mediante un código de cliente
            //si no existe se termina la operación. Si el resultado es afirmativo, se genera el despacho
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("-------------------- CLIENTE ---------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(ChequeoUsuario());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            Console.ReadKey();

            //DESPACHO: El sistema muestra todos los barcos disponibles con los puertos de origen y destino de cada viaje y las fechas de partida y arribo.
            //Es decir, crear un archivo con todos los datos de cada barco
            //mostrar lista de barcos disponibles/permitir buscar barco según alguna de sus características
            //hacer un menu: -mostar todos los barcos -buscar por característica. Hacer submenu si se elige buscar con las caracteristicas
            //El sistema crea un despacho con la información del barco y un número de despacho y solicita que se ingresen los clientes y las mercaderías a enviar.
            //Se muestran los datos del cliente y la mercaderia a transportar (ver si es mejor en el apartado cliente o aqui)
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("-------------------- DESPACHO --------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Despachar();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            Console.ReadKey();






            //mostar todos los datos y solicitar confirmación de despacho
            //al finalizar la operación para un cliente, preguntar si otro cliente quiere realizar despacho en el mismo barco

        }

        public static string ChequeoEmpleado()
        {
            string cadena, empleado;
            string[] vectorcabecera;
            string[] vectorcontenido;

            StreamReader Leer;
            FileStream Archivo;
            if (File.Exists($"{Constants.FileNameCSVEmpleados}") != false)
            {
                Archivo = new FileStream(Constants.FileNameCSVEmpleados, FileMode.Open);
                Leer = new StreamReader(Archivo);
                //cabecera
                cadena = Leer.ReadLine();
                vectorcabecera = cadena.Split(',');
                if (string.IsNullOrWhiteSpace(cadena) != true)
                {
                    Console.Write("Ingrese código de verificación de empleado: "); empleado = Console.ReadLine();
                    Console.Clear();
                    //contenido del archivo
                    while (Leer.EndOfStream == false)
                    {
                        cadena = Leer.ReadLine();
                        vectorcontenido = cadena.Split(',');
                        for (int i = 0; i < vectorcabecera.Count(); i++)
                        {
                            if (vectorcontenido[i] == empleado)
                            {
                                //agregar a la clase empleado: nombre y codigo de empleado
                                return ($"Empleado/a {vectorcontenido[0]} encontrado/a.");
                            }
                        }
                    }
                    Leer.Close();
                    Archivo.Close();
                    throw new EmpleadoInexistenteException();
                }
                else
                {
                    throw new CabeceraInexistenteException();
                }
            }
            throw new ArchivoInexistenteException();
        }

        public static string ChequeoUsuario()
        {
            string cadena, cliente;
            string[] vectorcabecera = new string[5];
            string[] vectorcontenido = new string[5];

            StreamReader Leer;
            FileStream Archivo;
            if (File.Exists($"{Constants.FileNameCSV}") != false)
            {
                Archivo = new FileStream(Constants.FileNameCSV, FileMode.Open);
                Leer = new StreamReader(Archivo);
                //cabecera
                cadena = Leer.ReadLine();
                vectorcabecera = cadena.Split(',');
                if (string.IsNullOrWhiteSpace(cadena) != true)
                {
                    Console.Write("Ingrese el nombre de un cliente: "); //también puede ser cod de cliente
                    cliente = Console.ReadLine();
                    Console.Clear();
                    //contenido del archivo
                    while (Leer.EndOfStream == false)
                    {
                        cadena = Leer.ReadLine();
                        vectorcontenido = cadena.Split(',');
                        for (int i = 0; i < vectorcabecera.Count(); i++)
                        {
                            if (vectorcontenido[i] == cliente)
                            {
                                //agregar a la clase cliente: nombre codigo y mercaderia del cliente
                                return ($"Cliente: {vectorcontenido[0]}\nMercadería: {vectorcontenido[1]}");
                            }
                        }
                    }
                    Leer.Close();
                    Archivo.Close();
                    throw new ClienteInexistenteException();
                }
                else
                {
                    throw new CabeceraInexistenteException();
                }
            }
            throw new ArchivoInexistenteException();
        }

        public static bool SeleccionBarco(int seleccion, ref List<Barco> barcos)
        {
            if (seleccion > 10 || seleccion < 0 || barcos[seleccion - 1].Disponibilidad != "Disponible")
            {
                return false;
            }
            else return true;
        }

        public static void Despachar()
        {

            Console.Clear();

            Random rnd = new Random(); //PARA EL CODIGO DE DESPACHO
            Barco A = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "7 / 6 / 06");
            Barco B = new Barco(40, 8, 10, "Tokyo", "15 / 5 / 23", "9 / 6 / 23");
            Barco C = new Barco(60, 12, 15, "Seoul", "15 / 5 / 23", "8 / 6 /23");
            Barco D = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "9 / 6 /23");
            Barco E = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
            Barco F = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "9 / 6 /23");
            Barco G = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
            Barco H = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "8 / 6 /23");
            Barco I = new Barco(50, 10, 15, "Tokyo", "15 / 5 / 23", "7 / 6 /23");
            Barco J = new Barco(50, 10, 15, "Seoul", "15 / 5 / 23", "9 / 6 /23");

            List<Barco> barcos = new List<Barco>();
            barcos.Add(A);
            barcos.Add(B);
            barcos.Add(C);
            barcos.Add(D);
            barcos.Add(E);
            barcos.Add(F);
            barcos.Add(G);
            barcos.Add(H);
            barcos.Add(I);
            barcos.Add(J);

            Console.WriteLine("Barcos disponibles:\n");
            //IMPRIME LOS BARCOS
            for (int i = 0; i < 10; i++)
            {
                if (barcos[i].Disponibilidad == "Disponible")
                {
                    Console.WriteLine($"Barco {i + 1}:\nPuerto de origen: {barcos[i].Origen}\nPuerto de destino: {barcos[i].Destino}" +
                    $"\nFecha de salida: {barcos[i].HorarioSalida}\nHorario de llegada: {barcos[i].HorarioLlegada}\n----------------------");
                }
            }

            Console.Write("\nSeleccione un barco: ");
            int seleccion = int.Parse(Console.ReadLine());
            SeleccionBarco(seleccion, ref barcos);
            Despacho despacho1 = new Despacho(barcos[seleccion - 1], rnd.Next(9000, 18000));
            Console.WriteLine("Despacho creado.");

            //el empleado deberá elegir la manera de transportar la mercaderia: bodega o contenedores
            //contenedores: mostrar descripción del producto y todos los números y medidas de los contenedores que tiene el cliente con dicha mercadería.
            //bodega: mostrar descripción de la mercadería y las toneladas a exportar.

            //agregar el despacho a la lista
            //luego debe preguntarle al cliente cuantas toneladas desea cargar
        }
    }
}

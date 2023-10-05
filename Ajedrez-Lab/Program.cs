using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Jugador 1", "Azul");
            Jugador jugador2 = new Jugador("Jugador 2", "Rojo");

            Fichas ficha = new Peon();
            Console.ReadKey();
        }
    }
}

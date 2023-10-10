using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //herencia
            Rectangulo Rec = new Rectangulo();
            Rec.Color = "Azul";
            Rec.LadoA = 10;
            Rec.LadoB = 5;
            Console.WriteLine($"Rectángulo -> Color: {Rec.Color}|Cantidad de lados: {Rec.CantLados}|Perímetro: {Rec.Perimetro}");

            Triangulo Tri = new Triangulo();
            Tri.Color = "Rojo";
            Tri.LadoA = 5;
            Tri.LadoB = 10;
            Tri.LadoC = 15;
            Console.WriteLine($"Triángulo -> Color: {Tri.Color}|Cantidad de lados: {Tri.CantLados}|Perímetro: {Tri.Perimetro}");

            Tri.Info();
            Rec.Info();

            Console.WriteLine("\nMétodo virtual");
            Tri.InfoCompleta();
            Rec.InfoCompleta();

            Console.ReadKey();
        }
    }
}

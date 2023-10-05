using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseLibro LibroA = new ClaseLibro();
            ClaseLibro LibroB = new ClaseLibro();
            ClaseLibro LibroC = new ClaseLibro();
            ClaseLibro LibroD = new ClaseLibro();
            //LibroA
            LibroA.Saga = "Harry Potter";
            LibroA.Titulo = "Y la Piedra Filosofal";
            LibroA.Tomo = 1;
            LibroA.Genero = "Fantasía";
            LibroA.Alto = 18;
            LibroA.Ancho = 12.5;
            Console.WriteLine($"Título del libro: {LibroA.Saga}{LibroA.Titulo}\nFormato: {LibroA.Formato}");
            //LibroB
            LibroB.Saga = "Harry Potter";
            LibroB.Titulo = "Y la Cámara Secreta";
            LibroB.Tomo = 2;
            LibroB.Genero = "Fantasía";
            LibroB.Alto = 22;
            LibroB.Ancho = 15.5;
            Console.WriteLine($"\nTítulo del libro: {LibroB.Saga}{LibroB.Titulo}\nFormato: {LibroB.Formato}");
            //LibroC
            LibroC.Saga = "El Señor de los Anillos";
            LibroC.Titulo = "La Comunidad del Anillo";
            LibroC.Tomo = 1;
            LibroC.Genero = "Fantasía Épica";
            LibroC.Alto = 22;
            LibroC.Ancho = 15.9;
            Console.WriteLine($"\nTítulo del libro: {LibroC.Saga}{LibroC.Titulo}\nFormato: {LibroC.Formato}");
            //LibroD
            LibroD.Titulo = "El Resplandor";
            LibroD.Genero = "Terror";
            LibroD.Alto = 29.7;
            LibroD.Ancho = 21;
            Console.WriteLine($"\nTítulo del libro: {LibroD.Titulo}\nFormato: {LibroD.Formato}");
            //Guardar libros en una estantería
            List<ClaseLibro> Estanteria = new List<ClaseLibro>();
            Estanteria.Add(LibroA);
            Estanteria.Add(LibroB);
            Estanteria.Add(LibroC);
            Estanteria.Add(LibroD);

            ClaseLibreria LibreriaA = new ClaseLibreria();
            //LibreriaA
            LibreriaA.Nombre = "El Ateneo";
            LibreriaA.Estanteria = "Fantasía";

            LibreriaA.AgregarLibro(LibroA);
            LibreriaA.AgregarLibro(LibroB);
            LibreriaA.AgregarLibro(LibroC);
            LibreriaA.AgregarLibro(LibroD);

            Console.WriteLine($"\nCantidad total de libros: {LibreriaA.CantidadTotalLibros}");

            Console.WriteLine($"\nCantidad de libros de fantasía: {LibreriaA.CantLibrosEstanteria("Fantasía")}");

            List<ClaseLibro> Listado = new List<ClaseLibro>();
            Listado = LibreriaA.MostrarLista("Fantasía");
            Console.WriteLine("\nCon for:");
            for (int i = 0; i < Listado.Count(); i++)
            {
                Console.WriteLine($"Lista de libros de Fantasía: {Listado[i].Saga}{Listado[i].Titulo}");
            }
            Console.WriteLine("\nCon foreach:");
            foreach (ClaseLibro aux in Listado)
            {
                Console.WriteLine($"Lista de libros de Fantasía: {aux.Saga}{aux.Titulo}");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Libreria
{
    internal class ClaseLibreria
    {
        //private nombre, nombre de la estanteria (otros libros del mismo genero en esa estanteria)
        private string _privNombre;
        private string _privEstanteria;
        private List<ClaseLibro> _privListaEstanteria;
        List<ClaseLibro> Encontrados = new List<ClaseLibro>();
        //constructor
        public ClaseLibreria()
        {
            this.Nombre = "";
            this.Estanteria = "";
            this._privListaEstanteria = new List<ClaseLibro>();
        }

        //L/E
        public string Nombre
        {
            get
            {
                return _privNombre;
            }
            set
            {
                _privNombre = value;
            }
        }

        public string Estanteria
        {
            get
            {
                return _privEstanteria;
            }
            set
            {
                _privEstanteria = value;
            }
        }

        //S/L
        public int CantidadTotalLibros //total de libros en la librería
        {
            get
            {
                return this._privListaEstanteria.Count;
            }
        }

        //metodos
        public List<ClaseLibro> MostrarLista(string genero)
        {
            for (int i = 0; i < _privListaEstanteria.Count; i++)
            {
                if (genero == _privListaEstanteria[i].Genero)
                {
                    Encontrados.Add(this._privListaEstanteria[i]);
                }
            }
            return Encontrados;
        }

        public bool AgregarLibro(ClaseLibro Libro)
        {
            this._privListaEstanteria.Add(Libro);
            return true;
        }

        public int CantLibrosEstanteria(string gen)
        {
            int contador = 0;
            for (int i = 0; i < _privListaEstanteria.Count; i++)
            {
                if (gen == _privListaEstanteria[i].Genero)
                {
                    contador += 1;
                }
            }
            return contador;
        }
    }
}

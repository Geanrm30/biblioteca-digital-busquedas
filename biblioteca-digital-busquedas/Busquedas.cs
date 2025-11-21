using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_digital_busquedas
{
    public static class Busquedas
    {
        public static Libro BuscarLibroLineal(List<Libro> libros, string tituloBuscado)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo.ToLower() == tituloBuscado.ToLower())
                {
                    return libro;
                }
            }

            return null; // No encontrado
        }
        public static List<Libro> BuscarCoincidencias(List<Libro> libros, string palabraClave)
        {
            List<Libro> resultados = new List<Libro>();

            foreach (var libro in libros)
            {
                if (libro.Descripcion.ToLower().Contains(palabraClave.ToLower()))
                {
                    resultados.Add(libro);
                }
            }

            return resultados;
        }
    }
}

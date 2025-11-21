using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    /// <summary>
    /// Contiene métodos de búsqueda en listas de libros.
    /// </summary>
    public static class Busquedas
    {
        /// <summary>
        /// Busca un libro por título mediante búsqueda lineal.
        /// </summary>
        /// <param name="libros">Lista de libros donde se realizará la búsqueda.</param>
        /// <param name="tituloBuscado">Título exacto del libro a buscar.</param>
        /// <returns>El libro encontrado; null si no se encuentra o si la lista es nula.</returns>
        public static Libro BuscarLibroLineal(List<Libro> libros, string tituloBuscado)
        {
            // Validación de parámetros nulos
            if (libros == null || tituloBuscado == null)
                return null;

            // Recorrer la lista comparando títulos (ignorando mayúsculas/minúsculas)
            foreach (var libro in libros)
            {
                if (string.Equals(libro.Titulo, tituloBuscado, StringComparison.OrdinalIgnoreCase))
                    return libro;
            }

            // Retorna null si no se encontró el libro
            return null;
        }

        /// <summary>
        /// Busca libros que contengan una palabra clave en la descripción.
        /// </summary>
        /// <param name="libros">Lista de libros donde se realizará la búsqueda.</param>
        /// <param name="palabraClave">Palabra clave a buscar dentro de las descripciones.</param>
        /// <returns>Lista de libros que contienen la palabra clave.</returns>
        public static List<Libro> BuscarCoincidencias(List<Libro> libros, string palabraClave)
        {
            List<Libro> resultados = new List<Libro>();

            if (libros == null || string.IsNullOrWhiteSpace(palabraClave))
                return resultados; // Retorna lista vacía si no hay datos

            // Recorrer la lista y agregar los libros cuya descripción contiene la palabra clave
            foreach (var libro in libros)
            {
                if (libro.Descripcion != null &&
                    libro.Descripcion.IndexOf(palabraClave, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    resultados.Add(libro);
                }
            }

            return resultados;
        }
    }
}

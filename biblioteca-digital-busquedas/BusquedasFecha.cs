using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    /// <summary>
    /// Contiene métodos para buscar libros según su fecha de publicación.
    /// </summary>
    public static class BusquedasFecha
    {
        /// <summary>
        /// Retorna el libro más reciente de una lista de libros.
        /// </summary>
        /// <param name="listaLibros">Lista de libros donde se realizará la búsqueda.</param>
        /// <returns>El libro más reciente; null si la lista está vacía o es nula.</returns>
        public static Libro LibroMasReciente(List<Libro> listaLibros)
        {
            if (listaLibros == null || listaLibros.Count == 0)
            {
                Console.WriteLine("La lista de libros está vacía. No se puede determinar el libro más reciente.");
                return null;
            }

            // Inicializar con el primer libro como el más reciente
            Libro reciente = listaLibros[0];

            // Recorrer la lista para encontrar el libro con mayor año
            foreach (var libro in listaLibros)
            {
                if (libro.Anio > reciente.Anio)
                    reciente = libro;
            }
            return reciente;
        }

        /// <summary>
        /// Retorna el libro más antiguo de una lista de libros.
        /// </summary>
        /// <param name="listaLibros">Lista de libros donde se realizará la búsqueda.</param>
        /// <returns>El libro más antiguo; null si la lista está vacía o es nula.</returns>
        public static Libro LibroMasAntiguo(List<Libro> listaLibros)
        {
            if (listaLibros == null || listaLibros.Count == 0)
            {
                Console.WriteLine("La lista de libros está vacía. No se puede determinar el libro más antiguo.");
                return null;
            }

            // Inicializar con el primer libro como el más antiguo
            Libro antiguo = listaLibros[0];

            // Recorrer la lista para encontrar el libro con menor año
            foreach (var libro in listaLibros)
            {
                if (libro.Anio < antiguo.Anio)
                    antiguo = libro;
            }
            return antiguo;
        }
    }
}

using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    /// <summary>
    /// Contiene métodos de búsqueda binaria en listas de libros.
    /// </summary>
    public static class BusquedaBinaria
    {
        /// <summary>
        /// Busca un libro por autor utilizando búsqueda binaria.
        /// </summary>
        /// <param name="listaLibros">Lista de libros donde se realizará la búsqueda.</param>
        /// <param name="autorBuscado">Nombre del autor a buscar.</param>
        /// <returns>Libro encontrado; null si no se encuentra o si los parámetros son inválidos.</returns>
        public static Libro BuscarPorAutor(List<Libro> listaLibros, string autorBuscado)
        {
            // Validar parámetros nulos o vacíos
            if (listaLibros == null || listaLibros.Count == 0)
            {
                Console.WriteLine("La lista de libros está vacía o no existe.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(autorBuscado))
            {
                Console.WriteLine("Debe ingresar un autor válido.");
                return null;
            }

            // Ordenar la lista por autor antes de aplicar la búsqueda binaria
            listaLibros.Sort((a, b) => string.Compare(a.Autor, b.Autor, StringComparison.OrdinalIgnoreCase));

            int izquierda = 0;
            int derecha = listaLibros.Count - 1;

            // Búsqueda binaria
            // Se compara el autor buscado con el del medio de la lista
            // Si es igual, se retorna
            // Si es mayor, se busca en la mitad derecha
            // Si es menor, se busca en la mitad izquierda
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int comparacion = string.Compare(listaLibros[medio].Autor, autorBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                    return listaLibros[medio]; // Autor encontrado
                else if (comparacion < 0)
                    izquierda = medio + 1;     // Mover límite izquierdo hacia la derecha
                else
                    derecha = medio - 1;       // Mover límite derecho hacia la izquierda
            }

            // Autor no encontrado en la lista
            Console.WriteLine("Autor no encontrado en la lista.");
            return null;
        }
    }
}

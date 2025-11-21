using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    public static class BusquedaBinaria
    {
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

            // Ordenar la lista por autor
            listaLibros.Sort((a, b) => string.Compare(a.Autor, b.Autor, StringComparison.OrdinalIgnoreCase));

            int izquierda = 0;
            int derecha = listaLibros.Count - 1;

            // Búsqueda binaria
            // Se compara el autor buscado con el del medio de la lista
            // Si es igual, se retorna
            // Si es mayor, buscamos en la mitad derecha
            // Si es menor, buscamos en la mitad izquierda
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int comparacion = string.Compare(listaLibros[medio].Autor, autorBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                    return listaLibros[medio];
                else if (comparacion < 0)
                    izquierda = medio + 1;  // Mover el límite izquierdo
                else
                    derecha = medio - 1;    // Mover el límite derecho
            }

            Console.WriteLine("Autor no encontrado en la lista.");
            return null; // No encontrado
        }
    }
}

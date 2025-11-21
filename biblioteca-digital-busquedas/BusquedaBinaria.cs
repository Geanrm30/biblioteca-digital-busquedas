using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    public static class BusquedaBinaria
    {
        public static Libro BuscarPorAutor(List<Libro> listaLibros, string autorBuscado)
        {
            if (listaLibros == null || autorBuscado == null)
                return null;

            // Ordenar la lista por autor
            listaLibros.Sort((a, b) => string.Compare(a.Autor, b.Autor, StringComparison.OrdinalIgnoreCase));

            int izquierda = 0;
            int derecha = listaLibros.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int comparacion = string.Compare(listaLibros[medio].Autor, autorBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                    return listaLibros[medio];
                else if (comparacion < 0)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return null; // No encontrado
        }
    }
}

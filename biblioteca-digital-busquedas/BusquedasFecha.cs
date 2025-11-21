using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    public static class BusquedasFecha
    {
        public static Libro LibroMasReciente(List<Libro> listaLibros)
        {
            if (listaLibros == null ||  listaLibros.Count == 0) return null;

            Libro reciente = listaLibros[0];
            foreach (var libro in listaLibros)
            {
                if (libro.Anio > reciente.Anio)
                    reciente = libro;
            }
            return reciente;
        }

        public static Libro LibroMasAntiguo(List<Libro> listaLibros)
        {
            if (listaLibros == null ||  listaLibros.Count == 0) return null;

            Libro antiguo = listaLibros[0];
            foreach (var libro in listaLibros)
            {
                if (libro.Anio < antiguo.Anio)
                    antiguo = libro;
            }
            return antiguo;
        }
    }
}

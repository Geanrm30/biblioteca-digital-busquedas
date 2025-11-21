using System;

namespace biblioteca_digital_busquedas
{
    /// <summary>
    /// Representa un libro en la Biblioteca Digital.
    /// </summary>
    public class Libro
    {
        /// <summary>
        /// Identificador único del libro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título del libro.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Autor del libro.
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Año de publicación del libro.
        /// </summary>
        public int Anio { get; set; }

        /// <summary>
        /// Descripción breve del contenido o temática del libro.
        /// </summary>
        public string Descripcion { get; set; }
    }
}

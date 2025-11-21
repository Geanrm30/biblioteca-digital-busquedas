using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_digital_busquedas
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>
            {
                new Libro{ Id=1, Titulo="Programación en C#", Autor="Alvarez", Anio=2020, Descripcion="Guía completa de C#." },
                new Libro{ Id=2, Titulo="Estructuras de datos", Autor="Martínez", Anio=2018, Descripcion="Incluye pilas, colas y árboles." },
                new Libro{ Id=3, Titulo="Inteligencia Artificial", Autor="Soto", Anio=2022, Descripcion="Conceptos modernos de IA." },
                new Libro{ Id=4, Titulo="Bases de Datos", Autor="López", Anio=2019, Descripcion="Normalización y SQL." },
            };
        }
    }
}

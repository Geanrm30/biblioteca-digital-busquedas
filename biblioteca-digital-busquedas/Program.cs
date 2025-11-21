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
            Console.WriteLine("=== Sistema de Búsqueda Biblioteca ===");
            Console.WriteLine("1. Búsqueda lineal por título");
            Console.WriteLine("2. Buscar coincidencias en descripción");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese título exacto: ");
                    string titulo = Console.ReadLine();
                    var libro = Busquedas.BuscarLibroLineal(libros, titulo);

                    if (libro != null)
                        Console.WriteLine($"Encontrado: {libro.Titulo} ({libro.Anio})");
                    else
                        Console.WriteLine("Libro no encontrado");
                    break;

                case 2:
                    Console.Write("Ingrese palabra clave: ");
                    string clave = Console.ReadLine();
                    var lista = Busquedas.BuscarCoincidencias(libros, clave);

                    if (lista.Count > 0)
                    {
                        Console.WriteLine("Resultados:");
                        foreach (var l in lista)
                            Console.WriteLine($"- {l.Titulo}: {l.Descripcion}");
                    }
                    else
                        Console.WriteLine("No se encontraron coincidencias.");
                    break;
            }
        }
    }
}

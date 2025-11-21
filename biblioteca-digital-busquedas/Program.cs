using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de libros de prueba
            List<Libro> libros = new List<Libro>
            {
                new Libro{ Id=1, Titulo="Programación en C#", Autor="Alvarez", Anio=2020, Descripcion="Guía completa de C#." },
                new Libro{ Id=2, Titulo="Estructuras de datos", Autor="Martínez", Anio=2018, Descripcion="Incluye pilas, colas y árboles." },
                new Libro{ Id=3, Titulo="Inteligencia Artificial", Autor="Soto", Anio=2022, Descripcion="Conceptos modernos de IA." },
                new Libro{ Id=4, Titulo="Bases de Datos", Autor="López", Anio=2019, Descripcion="Normalización y SQL." },
            };

            Console.WriteLine("=== Sistema de Búsqueda - Biblioteca Digital ===");

            int opcion;
            while (true)
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Búsqueda lineal por título");
                Console.WriteLine("2. Buscar coincidencias en descripción");
                Console.WriteLine("3. Búsqueda binaria por autor");
                Console.WriteLine("4. Libro más reciente y más antiguo");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                    break; // Entrada válida
                else
                    Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese título exacto del libro: ");
                    string titulo = Console.ReadLine();

                    var libroEncontrado = Busquedas.BuscarLibroLineal(libros, titulo);

                    if (libroEncontrado != null)
                        Console.WriteLine($"\nEncontrado: {libroEncontrado.Titulo} ({libroEncontrado.Anio})");
                    else
                        Console.WriteLine("\nLibro NO encontrado.");
                    break;

                case 2:
                    Console.Write("Ingrese palabra clave para buscar en la descripción: ");
                    string clave = Console.ReadLine();

                    var listaCoincidencias = Busquedas.BuscarCoincidencias(libros, clave);

                    if (listaCoincidencias.Count > 0)
                    {
                        Console.WriteLine($"\nSe encontraron {listaCoincidencias.Count} resultados:");
                        foreach (var libroCoincidente in listaCoincidencias)
                        {
                            Console.WriteLine($"- {libroCoincidente.Titulo}: {libroCoincidente.Descripcion}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontraron coincidencias.");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese el autor a buscar: ");
                    string autor = Console.ReadLine();
                    var libroAutor = BusquedaBinaria.BuscarPorAutor(libros, autor);
                    if (libroAutor != null)
                        Console.WriteLine($"Encontrado: {libroAutor.Titulo} ({libroAutor.Anio})");
                    else
                        Console.WriteLine("Autor no encontrado.");
                    break;

                case 4:
                    var reciente = BusquedasFecha.LibroMasReciente(libros);
                    var antiguo = BusquedasFecha.LibroMasAntiguo(libros);
                    Console.WriteLine($"Libro más reciente: {reciente.Titulo} ({reciente.Anio})");
                    Console.WriteLine($"Libro más antiguo: {antiguo.Titulo} ({antiguo.Anio})");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

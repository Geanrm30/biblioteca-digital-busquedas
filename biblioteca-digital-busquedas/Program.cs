using System;
using System.Collections.Generic;

namespace biblioteca_digital_busquedas
{
    /// <summary>
    /// Clase principal que contiene el menú de consola para la Biblioteca Digital.
    /// Permite realizar búsquedas de libros mediante diferentes algoritmos.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal que ejecuta la aplicación de consola.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos (no se utilizan).</param>
        static void Main(string[] args)
        {
            // Lista de libros de prueba para el sistema
            List<Libro> libros = new List<Libro>
            {
                new Libro{ Id=1, Titulo="Programación en C#", Autor="Alvarez", Anio=2020, Descripcion="Guía completa de C#." },
                new Libro{ Id=2, Titulo="Estructuras de datos", Autor="Martínez", Anio=2018, Descripcion="Incluye pilas, colas y árboles." },
                new Libro{ Id=3, Titulo="Inteligencia Artificial", Autor="Soto", Anio=2022, Descripcion="Conceptos modernos de IA." },
                new Libro{ Id=4, Titulo="Bases de Datos", Autor="López", Anio=2019, Descripcion="Normalización y SQL." },
            };

            int opcion;

            // Bucle para validar la opción ingresada por el usuario
            while (true)
            {
                Console.WriteLine("\n=== Sistema de Búsqueda Biblioteca ===");
                Console.WriteLine("1. Búsqueda lineal por título");
                Console.WriteLine("2. Buscar coincidencias en descripción");
                Console.WriteLine("3. Búsqueda binaria por autor");
                Console.WriteLine("4. Libro más reciente y más antiguo");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                    break; // La entrada es válida, salimos del bucle
                else
                    Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            }

            // Evaluación de la opción seleccionada por el usuario
            switch (opcion)
            {
                case 1:
                    // Búsqueda lineal por título exacto
                    Console.Write("Ingrese título exacto: ");
                    string titulo = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(titulo))
                    {
                        Console.WriteLine("Debe ingresar un título válido.");
                        break;
                    }

                    var libroEncontrado = Busquedas.BuscarLibroLineal(libros, titulo);

                    if (libroEncontrado != null)
                        Console.WriteLine($"Encontrado: {libroEncontrado.Titulo} ({libroEncontrado.Anio})");
                    else
                        Console.WriteLine("Libro no encontrado.");
                    break;

                case 2:
                    // Búsqueda por coincidencias en la descripción
                    Console.Write("Ingrese palabra clave: ");
                    string clave = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(clave))
                    {
                        Console.WriteLine("Debe ingresar una palabra clave válida.");
                        break;
                    }

                    var listaCoincidencias = Busquedas.BuscarCoincidencias(libros, clave);

                    if (listaCoincidencias.Count > 0)
                    {
                        Console.WriteLine($"Se encontraron {listaCoincidencias.Count} resultados:");
                        foreach (var libroCoincidente in listaCoincidencias)
                            Console.WriteLine($"- {libroCoincidente.Titulo}: {libroCoincidente.Descripcion}");
                    }
                    else
                        Console.WriteLine("No se encontraron coincidencias.");
                    break;

                case 3:
                    // Búsqueda binaria por autor
                    Console.Write("Ingrese el autor a buscar: ");
                    string autor = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(autor))
                    {
                        Console.WriteLine("Debe ingresar un autor válido.");
                        break;
                    }

                    var libroAutor = BusquedaBinaria.BuscarPorAutor(libros, autor);

                    if (libroAutor != null)
                        Console.WriteLine($"Encontrado: {libroAutor.Titulo} ({libroAutor.Anio})");
                    break;

                case 4:
                    // Buscar libro más reciente y más antiguo
                    var reciente = BusquedasFecha.LibroMasReciente(libros);
                    var antiguo = BusquedasFecha.LibroMasAntiguo(libros);

                    if (reciente != null && antiguo != null)
                    {
                        Console.WriteLine($"Libro más reciente: {reciente.Titulo} ({reciente.Anio})");
                        Console.WriteLine($"Libro más antiguo: {antiguo.Titulo} ({antiguo.Anio})");
                    }
                    break;

                default:
                    // Caso para opciones inválidas
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }

            // Mensaje final antes de salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

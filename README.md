# Biblioteca Digital Estudiantil – Sistema de Búsqueda

## Descripción
Este proyecto es un prototipo de sistema de búsqueda para una Biblioteca Digital Estudiantil.  
Permite localizar información de manera eficiente dentro de una colección de libros, autores y descripciones, utilizando algoritmos de búsqueda lineal, binaria y búsqueda por fechas.  

El sistema está desarrollado en **C#** y se ejecuta por **consola**.  

---

## Objetivos
- Implementar algoritmos de búsqueda simples en C#.  
- Permitir buscar libros por:
  - Título (búsqueda lineal)  
  - Autor (búsqueda binaria)  
  - Coincidencias en descripción  
  - Libro más reciente y más antiguo  
- Fomentar el uso de Git/GitHub para colaboración en equipo.  

---

## Integrantes del equipo
- **Geanfranco Rodriguez** – Implementación de búsqueda lineal y coincidencias en descripciones.  
- **Donald Romero** – Implementación de búsqueda binaria por autor y búsqueda por fechas.  

---

## Requisitos
- Visual Studio Community 2019 o superior  
- .NET Framework o .NET Core compatible  
- Git para control de versiones  

---

## Cómo funciona el sistema
Al ejecutar el programa en la consola, se presenta un menú con cuatro opciones principales:  

1. **Búsqueda lineal por título**  
   - El usuario ingresa el título exacto del libro que desea buscar.  
   - El sistema recorre toda la lista de libros (búsqueda lineal) hasta encontrar una coincidencia.  
   - Retorna el libro encontrado o un mensaje si no existe.  

2. **Búsqueda por coincidencias en descripción**  
   - El usuario ingresa una palabra clave.  
   - El sistema revisa la descripción de cada libro y devuelve todos los libros que contengan esa palabra.  
   - También muestra la cantidad de resultados encontrados.  

3. **Búsqueda binaria por autor**  
   - El usuario ingresa el nombre de un autor.  
   - La lista de libros se ordena alfabéticamente por autor y se aplica búsqueda binaria.  
   - Retorna el primer libro que coincida con el autor o un mensaje si no se encuentra.  

4. **Libro más reciente y más antiguo**  
   - El sistema analiza la lista de libros y determina cuál tiene el año de publicación más reciente y cuál el más antiguo.  
   - Muestra ambos libros con su título y año de publicación.  

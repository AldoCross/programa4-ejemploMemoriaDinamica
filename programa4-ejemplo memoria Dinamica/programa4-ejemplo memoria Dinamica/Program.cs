using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // Libreria necesaria

namespace programa4_ejemplo_memoria_Dinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicialicacion de la lista:
            ArrayList Biblioteca = new ArrayList();
            // A­­ñadimos libros a la lita:
            Biblioteca.Add("\n Algebra - Baldor. ");
            Biblioteca.Add(" La Biblia de C# - Jeff Fergunson. ");
            Biblioteca.Add(" Calculo de una Variable - James Stewart. ");
            Biblioteca.Add(" Estructuras de Datos en C++ - Joyanes L. ");
            Biblioteca.Add(" Estructura de Datos - Cairo, O. y Guardati, S. ");
            Biblioteca.Add(" Calculo de Varias Variables - James Stewart. ");
            
            
            // despliege los datos de la lista:
            Console.WriteLine(" **Estos Son los Libros Disponibles** ");
            for(int i = 0; i<Biblioteca.Count; i++)
            {
                string libro = (string)Biblioteca[i];
                Console.WriteLine(libro);
            }
            // Despliege del tamaño del arraylist:
            Console.WriteLine("\n **Datos del ArrayList** ");
            Console.WriteLine("\n Tamaño: " + Biblioteca.Count);
            // Despliege de la capacidad del arraylist:
            Console.WriteLine(" Capacidad: " + Biblioteca.Capacity);
            // Eliminamos un libro donado por la biblioteca:
            Biblioteca.RemoveAt(4);
            // tamano y capacidad despues de eliminar el elemento
            Console.WriteLine(" Tamaño despues de eliminar 1 elemento: " + Biblioteca.Count);
            Console.WriteLine(" Capacidad despues de eliminar 1 elemento: " + Biblioteca.Capacity);
            //cierre del prgrama:          
            Console.ReadKey(); 
        }
    }
}

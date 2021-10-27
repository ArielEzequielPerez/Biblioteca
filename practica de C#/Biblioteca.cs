using System;
using System.Collections.Generic;

class Biblioteca
    {
        List<Libro> libros = new List<Libro>();

        Libro nuevoLibro = new Libro("asd", "ddf");
        
        public void AgregarLibro(Libro libro,int cantidadCopias,int cantidadPrestado)
        {
            libro.cantidadDeCopias = cantidadCopias;
            libro.cantidadDePrestamo = cantidadPrestado;
            libros.Add(libro);
        }
        public void prestarLibro(){
            Console.WriteLine("Ingrese el nombre del libro que desea prestar");
            string nombreLibro = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del usuario que desea prestar");
            string nombreUsuario = Console.ReadLine();
            foreach (Libro libro in libros)
            {
                if (libro.nombre == nombreLibro)
                {
                    libro.cantidadDePrestamo++;
                }
            }
        }

        public void mostrarLibros(){
            foreach (Libro libro in libros)
            {
                libro.Mostrar();
            }
        }

    }

                  
                     
using System;

class Libro
{
    
    public string nombre = "";
    public string autor = "";
    
    public int cantidadDeCopias{ get; set; }
        
    public int cantidadDePrestamo { get; set;}

    public bool estadoLibro = false;

    public Libro(string nuevoNombre,string nuevoAutor)
    {   
        nombre = nuevoNombre;
        autor = nuevoAutor;
    }
    public void  Prestar()
    {
        if(estadoLibro)
        {
            estadoLibro = true;
            cantidadDePrestamo--;
        }
        else
        {
            estadoLibro = false;
        }
    }

    public void Devolver()
    {
        if(estadoLibro)
        {
            estadoLibro = false;
            cantidadDePrestamo++;
        }
        else
        {
            estadoLibro = true;
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Cantidad de copias: " + cantidadDeCopias);
        Console.WriteLine("Cantidad de disponibles: " + cantidadDePrestamo);
    }
    
}
    

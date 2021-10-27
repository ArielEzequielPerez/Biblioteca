using System;

namespace practica_de_C_
{
    class Program
    {
        static void Main(string[] args)
        {
          Libro caraACara = new Libro("caraACara", "gabriel rolon");          
          Libro fundamentosDeSO = new Libro("fundamentos de sistemas operativos", "silberschatz galvin");
          Biblioteca unaBiblioteca = new Biblioteca();


          unaBiblioteca.AgregarLibro(caraACara, 12, 4);
          unaBiblioteca.AgregarLibro(fundamentosDeSO, 22 ,6);

          unaBiblioteca.mostrarLibros();
    

       }
       
    }
}   

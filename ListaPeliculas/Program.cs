using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
   class Pelicula
   {
       private string Titulo ;
       private int Año;
       public Pelicula (string titulo , int año)
       {
         this.Titulo=titulo;
         this.Año=año;
       }
       public void Imprime ()
       {
       Console.WriteLine(Titulo + " " + Año );
       }

   }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula>Peliculas=new List<Pelicula>();
             Peliculas.Add(new Pelicula ("Interstellar" ,2014));
             Peliculas.Add(new Pelicula ("Inception",2010 ));
             Peliculas.Add(new Pelicula ("Hacksaw Ridge",2016 ));
             Peliculas.Add(new Pelicula ("The Pianist",2002 ));
             Peliculas.Add(new Pelicula ("Matrix", 1999 ));
            
            foreach(Pelicula a in Peliculas)
            a.Imprime();

        }
    }
}

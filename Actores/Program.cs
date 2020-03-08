using System;
using System.Collections.Generic;

namespace Actores
{
    class Actor
    {
        private string Nombre;
        private int AñoNacimiento;
        public Actor (string Nombre, int AñoNacimiento)
        {
            this.Nombre=Nombre;
            this.AñoNacimiento=AñoNacimiento;
        }
        public void setNombre(string n)
        {
            this.Nombre=n;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setAñoNacimiento (int x)
        {
            this.AñoNacimiento=x;
        }
        public int getAñoNacimiento()
        {
            return AñoNacimiento;
        }
    }
    class Pelicula
    {
     private string Titulo;
     private int Año;
     private List <Actor>Actores;
     public Pelicula (string Titulo, int Año)
     {
            this.Titulo=Titulo;
            this.Año=Año;
            Actores=new List<Actor>();
     }
     public void setTitulo (string t)
     {
         this.Titulo=t;
     }
     public string getTitulo()
     {
         return Titulo;
     }
     public void setAño (int y)
     {
         this.Año=y;
     }
     public int getAño ()
     {
         return Año;
     }
     public void AgregarActor(Actor A)
     {
         Actores.Add(A);
     }
     public void ImprimeActores()
         {
          Console.WriteLine(Titulo +" " + Año);
          foreach(Actor A in Actores)
          {
              Console.WriteLine(A.getNombre()+ " "+ A.getAñoNacimiento());
          }     
         }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula ("La La Land", 2016);
            p1.AgregarActor(new Actor(" Ryan Gosling", 1980));
            p1.AgregarActor(new Actor (" Emma Stone", 1988));
            Pelicula p2 = new Pelicula ("Avengers End Game", 2019);
            p2.AgregarActor(new Actor(" Robert Downey Jr.", 1965));
            p2.AgregarActor(new Actor(" Chris Evans",1981));
            Pelicula p3 = new Pelicula ("Star Wars: Episode VI - Return of the Jedi",1983);
            p3.AgregarActor(new Actor(" Mark Hamill",1951));
            p3.AgregarActor(new Actor (" Harrison Ford",1942));
            p3.AgregarActor(new Actor (" Carrie Fisher",1956));
            Pelicula p4 = new Pelicula ("Alice in Wonderland",2010);
            p4.AgregarActor(new Actor(" Johnny Deep",1963));
            p4.AgregarActor(new Actor(" Mia Wasikowska",1989));
            p4.AgregarActor(new Actor(" Anne Hathaway",1982));
            p4.AgregarActor(new Actor(" Helena Bonham Carter",1966));
            Pelicula p5 = new Pelicula("A Dog's Purpose",2017);
            p5.AgregarActor(new Actor(" Brittany Leanna Robertson",1990));
            p5.AgregarActor(new Actor(" Keneti James «KJ» Fitzgerald Apa",1997));
            p5.AgregarActor(new Actor(" Juliet van Kampen",1979));

            p1.ImprimeActores();
            p2.ImprimeActores();
            p3.ImprimeActores();
            p4.ImprimeActores();
            p5.ImprimeActores();
        }
    }
}

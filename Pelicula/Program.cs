// Tercera version con atributos en privado, y utilizando dos constructores, y el metodo Imprime.
using System;

namespace Peliculas
{
    class Pelicula
    {
    private string Titulo;
    private int Año;
    private string Pais;
    private string Director;
    public Pelicula (string Titulo , int Año)
    {
        this.Titulo = Titulo;
        this.Año = Año ;
    }
    public void Imprime ()
    {
        Console.WriteLine(Titulo);
        Console.WriteLine(Año);
    }
    public void setTitulo (string n)
    
    {
        this.Titulo = n ;
       
    } 
    public string getTitulo ()
    {
        return Titulo;
    }
    public void setAño(int x)
    {
       this.Año = x ;
    }
    public int getAño ()
    {
        return Año;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula P1 = new Pelicula ("La forma del agua", 2013) ;
            Pelicula P2 = new Pelicula ("El señor de los anillos", 2003);
           
            P1.Imprime();
            P2.Imprime();
            

        }
    }
}

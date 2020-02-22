// segunda version ahora utilizando los atributos en privado y utilizando el metodo this.
using System;

namespace Peliculas
{
    class Pelicula
    {
    private string Titulo;
    private int Año;
    private string Pais;
    private string Director;
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
            Pelicula P1 = new Pelicula () ;
            Pelicula P2 = new Pelicula ();
            P1.setTitulo("La forma del agua.");
            P2.setTitulo("El señor de los anillos.");
            P1.setAño(2013);
            P2.setAño(2003);
            
            Console.WriteLine ("{0} ({1})",P1.getTitulo(),P1.getAño());
            Console.WriteLine ("{0} ({1})",P2.getTitulo(),P2.getAño());

        }
    }
}

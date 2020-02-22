using System;

namespace Peliculas
{
    class Pelicula
    {
    public string Titulo;
    public int Año;
    public string Pais;
    public string Director;
    public void setTitulo (string n)
    {
        Titulo = n;
    }
    public string getTitulo ()
    {
        return Titulo;
    }
    public void setAño(int x)
    {
       Año = x;
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
            Pelicula P1 = new Pelicula ();
            Pelicula P2 = new Pelicula();
            P1.setTitulo("La forma del agua");
            P1.setAño(2017);
            P2.setTitulo("El señor de los anillos");
            P2.setAño(2003);
            Console.WriteLine ("{0} ({1})",P1.getTitulo(),P1.getAño());
            Console.WriteLine ("{0} ({1})",P2.getTitulo(),P2.getAño());

        }
    }
}

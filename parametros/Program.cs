using System;

namespace parametros
{
    class Valor
    {
      public void Multi2 ( int n)
      {
          n=n*2;
      }
      public void SumaUno ( int n)
      {
          n=n+1;
      }
      public void RestaUno ( int n)
      {
          n=n-1;
      }
      public void Divi2 ( int n)
      {
          n=n/2;
      }
    }
    class Usuario   
    {
        public string Nombre;
        public string Contraseña;
        public Usuario()
        {
            Nombre ="Gustavo";
            Contraseña = "Sistemas";
        }
    }
    class Restringido
    {
        static public void Censura(in Usuario u)
        {
            u.Nombre = "xxxxxxxxxx";
            u.Contraseña = "xxxxxxxxx";
        }
        static public void Cambia(in Usuario u)
        {
            u = new Usuario();
            u.Nombre = "Usuario";
            u.Contraseña ="Contraseña";
        }
        static void Main()
        {
            Usuario Per = new Usuario();
            Console.WriteLine(Per.Nombre);
            Console.WriteLine(Per.Contraseña);
            Censura(in Per); // Error "No se puede asignar a vairable 'in Usuario' por que es una variable ReadOnly."
            Console.WriteLine(Per.Contraseña);
            Cambia(in Per); // Error "No se puede asignar a vairable 'in Usuario' por que es una variable ReadOnly."
            Console.WriteLine(Per.Nombre);
            Cambia(in Per); // Error "No se puede asignar a vairable 'in Usuario' por que es una variable ReadOnly."
            Console.WriteLine(Per.Contraseña);
        }
    }
    
    //class Program
    //{
        //static void Main()
        //{
            //Valor p = new Valor();
            //int a = 2;int b = 2;int c = 2; int d =2; 
            //p.SumaUno(in a); 
            //p.RestaUno(in b);
            //p.Multi2(in c); 
            //p.Divi2(in d); 
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);            
        //}
    //}
}

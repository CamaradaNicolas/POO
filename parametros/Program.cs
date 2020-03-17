using System;

namespace parametros
{
    class Valor
    {
      public void Multi2 (in int n)
      {
          n=n*2;
      }
      public void SumaUno (in int n)
      {
          n=n+1;
      }
      public void RestaUno (in int n)
      {
          n=n-1;
      }
      public void Divi2 (in int n)
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
        static public void Censura( Usuario u)
        {
            u.Nombre = "xxxxxxxxxx";
            u.Contraseña = "xxxxxxxxx";
        }
        static public void Cambia(Usuario u)
        {
            u = new Usuario();
            u.Nombre = "Usuario";
            u.Contraseña ="Contraseña";
        }
        //static void Main()
        //{
            //Usuario Per = new Usuario();
            //Console.WriteLine(Per.Nombre);
            //Console.WriteLine(Per.Contraseña);
            //Censura(Per);
            //Console.WriteLine(Per.Contraseña);
            //Cambia(ref Per);
            //Console.WriteLine(Per.Nombre);
            //Cambia(ref Per);
            //Console.WriteLine(Per.Contraseña);
        //}
    }
    
    class Program
    {
        static void Main()
        {
            Valor p = new Valor();
            int a = 2;int b = 2;int c = 2; int d =2; 
            p.SumaUno(in a); //Error "No se puede asignar a variable 'in int'por que es una variable ReadOnly."
            p.RestaUno(in b); //Error "No se puede asignar a variable 'in int'por que es una variable ReadOnly."
            p.Multi2(in c); //Error "No se puede asignar a variable 'in int'por que es una variable ReadOnly."
            p.Divi2(in d); //Error "No se puede asignar a variable 'in int'por que es una variable ReadOnly."
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);            
        }
    }
}

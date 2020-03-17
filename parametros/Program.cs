using System;

namespace parametros
{
    class Valor
    {
      public void Multi2 (ref int n)
      {
          n=n*2;
      }
      public void SumaUno (ref int n)
      {
          n=n+1;
      }
      public void RestaUno (ref int n)
      {
          n=n-1;
      }
      public void Divi2 (ref int n)
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
        static public void Cambia(ref Usuario u)
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
            Censura(Per);
            Console.WriteLine(Per.Contraseña);
            Cambia(ref Per);
            Console.WriteLine(Per.Nombre);
            Cambia(ref Per);
            Console.WriteLine(Per.Contraseña);
        }
    }
    
    //class Program
    //{
        //static void Main()
        //{
            //Valor p = new Valor();
            //int a = 2;int b = 2;int c = 2; int d =2; 
            //p.SumaUno(ref a);
            //p.RestaUno(ref b);
            //p.Multi2(ref c);
            //p.Divi2(ref d);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);            
        //}
    //}
}

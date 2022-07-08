using System;

namespace EjerciciosBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine();

            String hora = DateTime.Now.ToString("hh:mm");

            Console.WriteLine("Hola " + nombre +", la hora es: "+hora);


        }
    }
}

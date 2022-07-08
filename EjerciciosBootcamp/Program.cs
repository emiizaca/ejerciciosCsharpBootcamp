using System;

namespace EjerciciosBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese su nombre: ");
            //String nombre = Console.ReadLine();

            //String hora = DateTime.Now.ToString("hh:mm");

            //Console.WriteLine("Hola " + nombre +", la hora es: "+hora);

            Console.WriteLine("Nombre? ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Apellido? ");
            String apellido = Console.ReadLine();
            Console.WriteLine("Edad? ");
            String edad = Console.ReadLine();
            Console.WriteLine("Sabe Programar? ");
            String sabeProgramar = Console.ReadLine();

            Console.WriteLine("El Sr. " + nombre + " " + apellido + " tiene " + edad + " años de edad y " + sabeProgramar + " sabe programar.");

            int numero = 25;
            if (numero > 18)
            {
                Console.WriteLine("El número es mayor de 18.");
            }

            char caracter = 'a';
            if(caracter == 'a')
            {
                Console.WriteLine("El caracter es igual a a");
            }

            if (numero > 18 && caracter == 'a')
            {
                Console.WriteLine("Se cumplen las 2 condiciones.");
            }

            if (numero < 18 || caracter == 'a')
            {
                Console.WriteLine("Se cumple al menos una condicion.");
            }
        }
    }

    class Coche
    {
        int puertas;
        int ruedas;
        String marca;
        bool ITVvigente;
    }

    class Mesa
    {
        float peso;
        float largo;
        String material;
        String color;
    }
}

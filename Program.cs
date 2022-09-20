 using System;

namespace CursoCPractica4_Bucles
{
    class Program
    {
        static void Main(string[] args)
         // Primer ejemplo: Uso de bucle While
        {
            Console.WriteLine("¿Deseas entrar en el bucle While?");
            string respuesta = Console.ReadLine();
            while (respuesta != "no") 
            {
                Console.WriteLine("Estás ejecutando el interior del bucle while");
                Console.WriteLine("Por favor, introduce tu nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine($"{nombre}, saldrás del bucle While cuando respondas 'no' a la pregunta");
                Console.WriteLine("¿Deseas repetir otra vez?");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Información: Has salido del bucle While");
        }
    }
}

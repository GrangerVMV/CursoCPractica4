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

            // Segundo ejemplo: Uso de bucle While para quiz adivinar número
            Random referenciaARandom = new Random();
            int numeroAleatorio = referenciaARandom.Next(0, 100);
            Console.WriteLine("Por favor, elige un número del 0-100");
            int numeroElegido = 101;
            int numIntentos = 0;
            while (numeroElegido != numeroAleatorio)
            {
                numIntentos++;
                numeroElegido = int.Parse(Console.ReadLine());
                if (numeroAleatorio > numeroElegido) Console.WriteLine("Vuelve a intentarlo, el número es mayor que el que has elegido");
                else if (numeroAleatorio < numeroElegido) Console.WriteLine("Vuelve a intentarlo, el número es menor que el que has elegido");
            }
            Console.WriteLine($"Enhorabuena, el número secreto era el {numeroAleatorio} y has acertado en {numIntentos} intentos");
        }
    }
}

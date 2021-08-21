using System;

namespace Excersices2Udemy
{

    class Program
    {
        static void Main(string[] args)
        {

            /// EJERCICIO 1 
            /*int numero = 0;
             int total = 0;

             for(int i = 0; i <= 5; i++)
             {
                 Console.WriteLine("Ingrese numero entero");
                 numero = Int32.Parse(Console.ReadLine());
                 total += numero;
             }
             Console.WriteLine("La suma es: " + total);
            */
            /// EJERCICIO 2 
            /* 
            int numero = 1;
            int factorial = 1;

            Console.WriteLine("Ingrese el numero para hallar el factorial");
            numero = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial del numero brindado es: " + factorial);
            */

            /// EJERCICIO 3 

            /*
            var random = new Random();
            var adivinar = 0;

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese numero a adivinar tiene 4 oportunidades");
                adivinar = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Numero que salio al azar es: "+random.Next(1, 10));

                if (adivinar.Equals(random))
                {
                    Console.WriteLine("GANASTE");

                }
                else
                {
                    Console.WriteLine("PERDISTE, te quedan {0} oportunidades" +i);

                }
            */

            /// EJERCICIO  

            int[] datos={5,3,8,1,4};

            int max=Int32.MinValue;
            
            for(int i = 0; i < datos.Length; i++)
            {
                if(datos[i] > max)
                {
                    max = datos[i];
                }
            }
            Console.WriteLine("El Maximo es: " + max);
        }




    }
}


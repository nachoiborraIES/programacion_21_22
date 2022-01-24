using System;

// Raúl García

namespace SaltoTrampolin
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[args.Length];

            if (validarNotas(args, numeros))
            {
                Console.WriteLine(CalcularMedia(numeros).ToString("N2"));
            }

        }

        static bool validarNotas(string[] args, int[] numeros)
        {
            bool notasCorrectas = false;

            int contador = 0; 

            for (int i = 0; i < args.Length; i++)
            {
                numeros[i] = int.Parse(args[i]);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0 && numeros[i] <= 10)
                {
                    contador++;
                }
                else
                {
                    Console.WriteLine("Notas incorrectas");
                }

            }

            if(contador == 5)
            {
                notasCorrectas = true;
            }

            return notasCorrectas;

        }

        static double CalcularMedia(int[] numeros)
        {
            double media = 0.00;

            Array.Sort(numeros);

            for (int j = 1; j < numeros.Length - 1; j++)
            {
                media += numeros[j];
            }

            media /= 3;

            return media;
        }

    }
}

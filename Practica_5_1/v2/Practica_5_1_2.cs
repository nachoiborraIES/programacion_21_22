/*Programa que calcula la media, mediana y la moda mediante una función
 * llamada CalcularEstadisticas*/
// Roberto Fito
 
using System;

class Practica_5_1_2
{
	static int[] CopiarArray(int[] numeros)
	{
		int[] copiaNumeros = new int[numeros.Length];
		
		for(int i = 0; i < numeros.Length; i++)
		{
			copiaNumeros[i] = numeros[i];
		}
        
		Array.Sort(copiaNumeros);

		return copiaNumeros;
	}
	
	static int Mediana(int[] numeros)
	{
		int mediana;
		int[] copiaNumeros = CopiarArray(numeros);
		
		mediana = copiaNumeros[numeros.Length/2];
		
		return mediana;
	}
	
	static double Media(int[] numeros)
	{
		double media = 0;
		for(int i = 0; i < numeros.Length; i++)
		{
			media += numeros[i];
		}
		media /= numeros.Length;
		
		return media;
	}
	
	static int Moda(int[] numeros)
	{
		int[] copiaNumeros = CopiarArray(numeros);
		int numModa = 0, totalVeces = 0;
		
		for(int i = 0; i < copiaNumeros.Length; i++)
		{
			int numVeces = 0;
			int j = 0;
			while(j < copiaNumeros.Length)
			{
				if(copiaNumeros[j] == copiaNumeros[i]) numVeces++; 
				j++;
			}
			
			if(numVeces > totalVeces)
			{
				numModa = copiaNumeros[i];
				totalVeces = numVeces;
			}
		}
		
		return numModa;
	}
	
	static void CalcularEstadisticas(int[] numeros, out double media,	
		out int mediana, out int moda)
	{
		media = Media(numeros);
		mediana = Mediana(numeros);
		moda = Moda(numeros);		
	}
	
	static void Main()
	{
		int[] numeros = { 3, 8, 6, 17, 4, 2, 9, 3, 10, 12, 9, 3, 2, 10};
		int mediana, moda;
		double media;
			
		CalcularEstadisticas(numeros, out media, out mediana, out moda);
		Console.WriteLine("La media es {0}", media);
		Console.WriteLine("La mediana es {0}", mediana);
		Console.WriteLine("La moda es {0}", moda);
	}
} 

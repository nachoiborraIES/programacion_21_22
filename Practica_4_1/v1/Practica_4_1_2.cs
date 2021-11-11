/*
 * Programa que pide al usuario un numero N de filas y columnas creando
 * un array bidimensional de N valores, le pide que los rellene con
 * ceros y unos y le indica si es una matriz de identidad
 * 
 * Klavier Navarro
 */

using System;
class Practica_4_1_2
{
	static void Main()
	{
		int N, filas, columnas;
		int[,] valores;
		bool identidad = true;
		
		Console.WriteLine("Dime un numero de filas y columnas:");
		N = Convert.ToInt32(Console.ReadLine());
		
		valores = new int[N,N];
		
		Console.WriteLine("Introduce los valores (0 o 1) para cada " + 
		"casilla de la tabla:");
		
		for(filas = 0; filas < N; filas++)
		{
			for(columnas = 0; columnas < N; columnas++)
			{
				Console.Write("Dime el valor de la casilla {0},{1}: ", 
				filas, columnas);
				valores[filas,columnas] = 
				Convert.ToInt32(Console.ReadLine());
				
				if((filas == columnas && valores[filas,columnas] != 1)||
					(filas != columnas && valores[filas,columnas] != 0))
				{
					identidad = false;
				}
			}
		}
		
		if(identidad)
		{
			Console.WriteLine("Es una matriz identidad");
		}
		else
		{
			Console.WriteLine("No es una matriz identidad");
		}
	}
}

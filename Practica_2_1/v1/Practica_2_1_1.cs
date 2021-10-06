/*Programa que le pide al usuario tres temperaturas en grados centígrados, 
 *y en función de los valores, muestra en que época del año se encuentra*/
 
// José Ignacio García 
 
using System;

class Practica_2_1_1
{
	static void Main ()
	{
		Console.WriteLine("Escribe tres temperaturas en grados centígrados:");
		
		int temperatura1 = Convert.ToInt32(Console.ReadLine());
		int temperatura2 = Convert.ToInt32(Console.ReadLine());
		int temperatura3 = Convert.ToInt32(Console.ReadLine());
		
		if(temperatura1 >= 25 && temperatura2 >= 25 && temperatura3 >= 25)
		{
		    Console.WriteLine("Es verano");
		}
			
		else
		{
			if (temperatura1 < 15 || temperatura2 < 15 || temperatura3 < 15)
			{
				Console.WriteLine("Es invierno");
			}	
			
			else
			{
				Console.WriteLine("Es primavera u otoño");
			}
		}	
	}
}

/*
 * Programa que pide al usuario cuantos valores de bolsa va a
 * introducir, los almacena en un array, los examina e indica si las
 * acciones estan al alza, a la baja u oscilando
 * 
 * Klavier Navarro
 */

using System;
class Practica_4_1_1
{
	static void Main()
	{
		int numValores, mayor = 1, menor = 1;
		float[] valores;
		
		Console.WriteLine("Dime cuantos valores vas a introducir:");
		numValores = Convert.ToInt32(Console.ReadLine());
		valores = new float[numValores];
		
		Console.WriteLine("Introduce esos valores:");
		for(int i = 0; i < numValores; i++)
		{
			valores[i] = Convert.ToSingle(Console.ReadLine());
		}
		
		for(int i = 0; i < numValores - 1; i++)
		{
			if(valores[i+1] >= valores[i])
			{
				mayor++;
			}
			else if(valores[i+1] <= valores[i])
			{
				menor++;
			}
		}
		
		if(mayor == numValores)
		{
			Console.WriteLine("Las acciones estan al alza");
		}
		
		else if(menor == numValores)
		{
			Console.WriteLine("Las acciones estan a la baja");
		}
			
		else
		{
			Console.WriteLine("Las acciones estan oscilando");
		}
	}
}

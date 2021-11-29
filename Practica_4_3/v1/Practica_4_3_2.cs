/*
 * Programa que le pide al usuario que complete una lista de invitados,
 * los ordena alfabeticamente y crea grupos.
 * 
 * Yeray Mañogil
 * */
using System;

class Practica_4_3_2
{
	static void Main()
	{
		string nombres;
		string[] partes;
		bool excepcion = true;
		
		Console.WriteLine("Escriba la lista de invitados de la boda:");
		nombres = Console.ReadLine();
		
		partes = nombres.Split(',');
		
		for(int i = 0; i < partes.Length; i++)
		{
			for(int j = 0; j < partes.Length - i - 1; j++)
			{
				if(partes[j].CompareTo(partes[j + 1]) > 0)
				{
					string auxiliar = partes[j];
					partes[j] = partes[j+1];
					partes[j+1] = auxiliar;
				}
			}
		}
		
		if(partes.Length > 0)
		{
			for(int i = 0; i < partes.Length - 1; i++)
			{
				Console.Write("{0},", partes[i]);
			}
		}
		Console.Write("{0}", partes[partes.Length - 1]);
		Console.WriteLine();
		
		
		
		for(int i = 2; i < partes.Length; i++)
		{
			if(partes.Length % i == 0)
			{
				excepcion = false;
				Console.WriteLine("Este grupo es de {0}", i);
				
				for(int j = 1; j <= partes.Length; j++)
				{
					if(j % i == 0)
					{
						Console.WriteLine("{0}",partes[j - 1]);
					}
					else
					{
						Console.Write("{0}-", partes[j - 1]);
					}
				}
			}
		}
		if(excepcion)
			Console.WriteLine("No se puede agrupar");
	}
}

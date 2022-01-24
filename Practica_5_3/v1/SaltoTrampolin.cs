/*Programa en el que le pasemos al programa principal (Main), 
 * a través de los args de entrada, una serie de 5 notas enteras (de 0 a 10)
 *  de un concurso de saltos de trampolín. El programa debe comprobar
 *  que las 5 notas son válidas. Si falta alguna nota o no son válidas,
 *  mostrará el mensaje de "Notas incorrectas" y finalizará. Si todas
 *  son válidas, debe descartar la menor y la mayor de ellas, y sacar
 *  la nota media con las tres notas restantes. La nota media se
 *  mostrará por pantalla redondeada con 2 decimales.
 * 
 * Roberto Fito
 * 
 */

using System;

class SaltoTrampolin
{  	
	static bool ComprobarNotas(string[] args)
	{
		int[] notas = new int[5];
		bool notasValidas = true;
		if(args.Length == notas.Length)
		{
			for(int i = 0; i < args.Length; i++)
			{
				notas[i] = Convert.ToInt32(args[i]);
				if(notas[i] > 10 || notas[i] < 0)
				{
					notasValidas = false;
				}
			}
		}
		else
		{
			notasValidas = false;
		}
		return notasValidas;
	}
	
	static int[] DescartarNotas(string[] args)
	{
		int[] notas = new int[5];
		int[] notasDefinitivas = new int[3];
		for(int i = 0; i < args.Length; i++)
		{
			notas[i] = Convert.ToInt32(args[i]);				
		}
		Array.Sort(notas);
		for(int i = 0; i < notasDefinitivas.Length; i++)
		{
			notasDefinitivas[i] = notas[i+1];
		}
		return notasDefinitivas;
	}
	
	static float CalcularMedia(int[] notas)
	{
		float media = 0;
		for(int i = 0; i < notas.Length; i++)
		{
			media += notas[i];
		}
		media /= notas.Length;
		return media;
	}
	static void Main(string[] args)
    {
		bool notasValidas = ComprobarNotas(args);
		if(!notasValidas)
		{
			Console.WriteLine("Notas incorrectas");
		}
		else
		{
			Console.WriteLine("Nota final: {0}",
				CalcularMedia(DescartarNotas(args)).ToString("N2"));
		}
		
	}
}

using System;
/*Programa que dibuja una figura la cual la altura dependerá del número
 * proporcionado por el usuario*/

// Roberto Fito

class Práctica0203
{
	static void Main()
	{
		int altura, espacios, asteriscos;
		Console.Write("Escriba la altura de la figura: ");
		altura = Convert.ToInt32(Console.ReadLine());
		asteriscos = 1;
		espacios = altura - 1;
		for(int h = 1 ; h <= altura; h++)
		{
			for(int v = 1 ; v <= h; v++)
			{
				Console.Write("*");
			}
			for(int c = 1 ; c <= espacios * 2; c++)
			{
				Console.Write(" ");
			}
			for(int b = 1 ; b <= asteriscos ; b++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			asteriscos++;
			espacios--;
		}
	}
}

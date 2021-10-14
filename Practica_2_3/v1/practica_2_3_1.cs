/*En esta practica nos pide que le pidamos al usuario una altura
 * y dibuje una figura como un triangulo invertido que lo de fuera del
 * triangulo sean asteriscos. Para ello tenemos que usar el bucle for
 *  inicial para decir la altura y el otro bucle for para decirle cuando
 * tiene que poner un astericos o un espacio o bien cambiar de linea.*/
 
 //Realizado Por Manuel Pérez Moya 1ºDAM B.

using System;

class practica_2_3_1
{
	static void Main()
	{
		int altura_triangulo;
		
		Console.Write("Introduce la altura del triangulo: ");
		altura_triangulo = Convert.ToInt32(Console.ReadLine());
		
		for( int j = 1; j <= altura_triangulo; j++)
		{
			for( int k = 1; k <= 2*altura_triangulo; k++)
			{
				if(k <= j || k >=2*altura_triangulo+1-j)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}
			
			Console.WriteLine();
		
		}
	}
}

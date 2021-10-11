/*Programa que le pide al usuario dos notas hasta que de el valor 
 * correcto, despues mostrara la media de las dos notas */

// Alejandro Alcaraz

using System;

class ejercicio
{
	static void Main()
	{
		int nota1,nota2;
		do
		{
			Console.WriteLine("Introduce las dos notas");
			nota1=Convert.ToInt32(Console.ReadLine());
			nota2=Convert.ToInt32(Console.ReadLine());
			
			if(nota1<0||nota2>10)
			{
				Console.WriteLine("Error en el primer numero");
			}
			else if(nota2<0||nota2>10)
			{
				Console.WriteLine("Error en el segundo numero");
			}
		}
		while(nota1<0||nota1>10||nota2<0||nota2>10);
		Console.WriteLine("Tu media es {0}",(nota1 + nota2)/2);
	}
}

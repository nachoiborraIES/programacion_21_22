/* Insertado de un numero de grados por parte del usuario, para posteriormente
 * mediante una formula, mostrar por pantalla el resultado de la conversion
 * pasando de un tipo de valor a otro.*/

// Alvaro Castillo

using System;
class ejercicio
{
	static void Main()
	{
		Console.WriteLine("Introduce la temperatura en grados");
		int grados=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0}ºC Equivalen a {1}ºF",grados,grados*9/5+32);
	}
}

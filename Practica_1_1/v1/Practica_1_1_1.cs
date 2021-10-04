/*Practica 1_1_1 Álvaro Castillo Bermejo
 *Calculo de las medias del examen y las prácticas, 70% y 30% respectivamente
 *introducidos por el usuario y la salida por pantalla de la media total.
*/

// Alvaro Castillo

using System;
class ejercicio
{
	static void Main()
	{
		int examen,practica;
		Console.WriteLine("Introduce la nota de tu examen");
		examen=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce la nota de tus prácticas");
		practica=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("nota media : {0}",(examen*70/100)+(practica*30/100));
	}
}

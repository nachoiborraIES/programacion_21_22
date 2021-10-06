//~ Pide al usuario su nota trimestral (entero de 0 a 10), 
//~ y en función de su valor, le diga si tiene un SUSPENSO, 
//~ APROBADO (5 o 6), NOTABLE (7 u 8) o SOBRESALIENTE (9 o 10).

// Santiago Hoyos
 
using System;

class Practica212
{
	static void Main()
	{
		Console.WriteLine("Escribe tu nota:");
		int nota = Convert.ToInt32(Console.ReadLine());
		
		switch(nota)
		{
			case 0: goto case 4;
			case 1: goto case 4;
			case 2: goto case 4;
			case 3: goto case 4;
			case 4:
				Console.WriteLine("SUSPENSO");
				break;
			case 5: goto case 6;
			case 6:
				Console.WriteLine("APROBADO");
				break;
			case 7: goto case 8;
			case 8:
				Console.WriteLine("NOTABLE");
				break;
			case 9: goto case 10;
			case 10:
				Console.WriteLine("SOBRESALIENTE");
				break;
			default:
				Console.WriteLine("No es una nota aceptable");
				break;
		}
	}
}

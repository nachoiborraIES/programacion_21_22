/* Programa que pide la nota de su usuario y le dice si es suspenso, aprobado,
 * etc...
 * Daniel Marín Giner
*/
using System;

class Practica_2_1_2 {
    
	static void Main() {
	
		int nota;
	
		Console.WriteLine("Dime tu nota:");
		nota= Convert.ToInt32(Console.ReadLine());
	
		switch(nota)
		{
			case 1:
			case 2:
			case 3:
			case 4:
				Console.WriteLine("SUSPENSO");
				break;
			case 5:
			case 6:
				Console.WriteLine("APROBADO");
				break;
			case 7:
			case 8:
				Console.WriteLine("NOTABLE");
				break;
			case 9:
			case 10:
				Console.WriteLine("SOBRESALIENTE");
				break;
			default:
				Console.WriteLine("Nota incorrecta");
				break;
		}	
	}
}

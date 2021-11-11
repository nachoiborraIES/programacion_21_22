//~ El programa almacena la evolución del valor de unas acciones en  bolsa 
//~ (valores reales). Le pediremos al usuario cuántos valores va a introducir, 
//~ y después almacenaremos esos valores en un array (de floats). 
//~ Al finalizar, debemos examinar los valores almacenados y decirle al usuario:

	//~ 1. Si cada valor es mayor o igual que el anterior: 
		//~ "Las acciones están al alza"
	//~ 2. Si cada valor es menor o igual que el anterior: 
		//~ "Las acciones están a la baja"
	//~ 3. Si no sigue ninguno de los dos patrones anteriores: 
		//~ "Las acciones están oscilando"

// Santiago Hoyos
		
using System;

class Practica_4_1_1
{
	static void Main()
	{
		int tamanyoArray;
		int cambios = 0;
		
		Console.WriteLine("¿Cuantos valores va a introducir?");
		tamanyoArray = Convert.ToInt32(Console.ReadLine());
		
		float[] acciones = new float[tamanyoArray];
		
		Console.WriteLine("Introduce los {0} valores: ", tamanyoArray);
		
		for(int i = 0; i < acciones.Length; i++)
		{
			acciones[i] = Convert.ToSingle(Console.ReadLine());
		}
		
		for(int i = 0; i < (acciones.Length-1); i++)
		{
			if (acciones[i] < acciones[i+1])
			{
				cambios++;
			}
			
			if (acciones[i] > acciones[i+1])
			{
				cambios--;
			}
		}

		if (cambios == (acciones.Length-1))
		{
			Console.WriteLine("Las acciones están al alza");
		}
		
		else if (cambios == -(acciones.Length-1))
		{
			Console.WriteLine("Las acciones están a la baja");
		}
		
		else
		{
			Console.WriteLine("Las acciones están oscilando");
		}
	}
}

using System;

/*Programa que utiliza funciones para mostrar un menú y comprobar
la opción elegida por el usuario*/
// Alejandro Ribeiro

public class Practica511{
	static int ImprimirMenu(string[] menu, int min, int max){
		int opcion = 0;
		bool opcionValida = false;
		do{
			for (int x = 1; x <= menu.Length; x++){
				Console.WriteLine(x+". "+menu[x-1]);
			}
			try{
				opcion = Convert.ToInt32(Console.ReadLine());
				if (opcion > max || opcion < min){
					opcionValida = false;
				}
				else{
					opcionValida = true;
				}
			}
			catch{
				opcionValida = false;
			}
			if (!opcionValida){
				Console.WriteLine("Opción no válida");
			}
			Console.WriteLine();
		}while(!opcionValida);
		return opcion;
	}
	static void Main(){
		string[] menu = new string[] {"Insertar nuevo elemento" ,
		"Borrar elemento","Mostrar elementos" , "Buscar elemento" , 
		"Salir"};
		int opcion = ImprimirMenu(menu, 1, menu.Length)-1;
		Console.WriteLine("Has elegido la opción: " + menu[opcion]);
	}
}

/* Matias Agustín Piombo
 * 
 * Programa para enviar un menú a una función, comprobar la opción y devolver 
 * la opción desde el main.
 */

using System;

class Practica_5_1_1{
	
	static void Main(){
		const int min=1;
		int opcion=0;
		string[] opsMenu= {"Insertar nuevo elemento.", "Borrar elemento.",
			 "Mostrar elementos.", "Buscar elemento.", "Salir."};

		opcion=ImprimirMenu(opsMenu, min);
		
		Console.WriteLine("Tu opcion es: {0}.", opcion);
	}
	
	static int ImprimirMenu(string[] opsMenu, int min){
		int opcion=0;
		bool correcto=false;

		for(int i=0;i<opsMenu.Length;i++){
			Console.WriteLine("{0}. {1}", i+1, opsMenu[i]);
		}
		Console.WriteLine();
		do{
			try{
				Console.Write("Introduce la opcion: ");
				opcion=Convert.ToInt32(Console.ReadLine());
				
				if(opcion<=opsMenu.Length && opcion>=min)
					correcto=true;
				else
					Console.WriteLine("Opción incorrecta");
					
			}catch(Exception){
					Console.WriteLine("Opción incorrecta");
			}
		}while(correcto==false);
		return opcion;
	}
}

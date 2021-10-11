/*Programa que le pide al usuario dos números y realice un conteo desde el 
primero hasta el segundo. 
Carla Javaloyes Toledo*/

using System;
class Practica_2_2_2{
	static void Main(){
		
		int n1, n2;
		
		Console.WriteLine("Introduce un número");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		if (n1<n2){
			for (int i = n1 ; i<=n2;i++){
				Console.Write(i);
			}
		}
		
		else if (n1 == n2){
			Console.Write(n1);
		}
		
		else{
			for (int i = n1 ; i>=n2;i--){
				Console.Write(i);
			}
		}
	}
		
}		

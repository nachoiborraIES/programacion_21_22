/*pasar de grados centígrados a grados Fahrenheit */
// Samuel Cano

using System;
class Practica_1_1_2
{
    static void Main()
	{
		int gradosC;
				
		Console.WriteLine("Introduce grados Centigrados para pasarlos a Fahrenheit");
		gradosC = System.Convert.ToInt32(System.Console.ReadLine());
						
		Console.WriteLine( gradosC+ " grados Centígrados = " 
		+(gradosC * 9 / 5 + 32)+" grados Fahrenheit " );
    }
}

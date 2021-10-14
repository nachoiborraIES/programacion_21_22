// Agustín Sirvent

using System;

class Ejercicio_2_3_2
{
	static void Main()
	{
		/*Necesitamos hacer un programa que calcule el cambio de una tienda,
		 * dando siempre el cambio en unidades mas altas*/

		int importe, totalPagado, cambio;
		//"b" de billetes y "m" de monedas
		int b50 = 0, b20 = 0, b10 = 0, b5 = 0, m2 = 0, m1 = 0;

		Console.WriteLine("Introduzca el total a pagar: ");
		importe = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("\nIntroduzca el pago efectuado: ");
		totalPagado = Convert.ToInt32(Console.ReadLine());

		if (importe == totalPagado){
			Console.WriteLine("\nEl importe es exacto");
		}
		else if (importe > totalPagado){
			Console.WriteLine("\nImporte incorrecto");
		}
		else{
			cambio = totalPagado - importe;
			Console.WriteLine("\nTotal a devolver: {0}", cambio);

			if (cambio >= 50){
				b50 = cambio / 50;
				Console.WriteLine("{0} billetes de 50", b50);
				cambio -= b50 * 50;
            }
			if (cambio >= 20){
				b20 = cambio / 20;
				Console.WriteLine("{0} billetes de 20", b20);
				cambio -= b20 * 20;
			}
			if (cambio >= 10){
				b10 = cambio / 10;
				Console.WriteLine("{0} billetes de 10", b10);
				cambio -= b10 * 10;
			}
			if (cambio >= 5){
				b5 = cambio / 5;
				Console.WriteLine("{0} billetes de 5", b5);
				cambio -= b5 * 5;
			}
			if (cambio >= 2){
				m2 = cambio / 2;
				Console.WriteLine("{0} monedas de 2", m2);
				cambio -= m2 * 2;
			}
			if (cambio >= 1){
				m1 = cambio;
				Console.WriteLine("{0} monedas de 1", m1);
			}
		}
	}
}

				
				
				
				
				
				
				
				
				
				
				

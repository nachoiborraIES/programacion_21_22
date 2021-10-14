/*En la practica 2_3_2 se nos pide que simulemos el cambio de una tienda.
 * El usuario tiene que meter el importe de la compra y cuanto dinero
 *  paga el cliente. Si el importe es exacto diremos que es exacto, si 
 * es incorrecto tambien lo mostraremos y si hay que generar el cambio
 * mostraremos el desglose.*/
 
 //Realizado por Manuel Pérez Moya 1º DAM B.

using System;

class practica_2_3_2
{
	static void Main()
	{
		int coste, pago, cambio, contador_50=0, contador_20=0, 
		contador_10=0,contador_5=0, contador_2=0, contador_1=0;
		
		Console.Write("Dime el precio total de la venta: ");
		coste = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Dime la cantidad con la que paga el cliente: ");
		pago = Convert.ToInt32(Console.ReadLine());
		
		cambio = pago - coste;
		
		if(cambio == 0)
		{
			Console.WriteLine
			("El importe pagado es exacto al precio de la compra");
		}
		
		else if(cambio > 0)
		{
			
			Console.WriteLine("Total a devolver: {0}", cambio);
			
			while(cambio !=0)
			{
				if(cambio >= 50)
				{
					cambio = cambio - 50;
					contador_50++;
				}
				else if(cambio >= 20)
				{
					cambio = cambio - 20;
					contador_20++;
				}
				else if(cambio >= 10)
				{
					cambio = cambio - 10;
					contador_10++;
				}
				else if(cambio >= 5)
				{
					cambio = cambio - 5;
					contador_5++;
				}
				else if(cambio >= 2)
				{
					cambio = cambio - 2;
					contador_2++;
				}
				else if(cambio == 1)
				{
					cambio = cambio - 1;
					contador_1++;
				}
			}
			
			if(contador_50 != 0)
			{
				Console.WriteLine(" {0} de 50.", contador_50);
			}
			if(contador_20 != 0)
			{
				Console.WriteLine(" {0} de 20.", contador_20);
			}
			if(contador_10 != 0)
			{
				Console.WriteLine(" {0} de 10.", contador_10);
			}
			if(contador_5 != 0)
			{
				Console.WriteLine(" {0} de 5.", contador_5);
			}
			if(contador_2 != 0)
			{
				Console.WriteLine(" {0} de 2.", contador_2);
			}
			if(contador_1 != 0)
			{
				Console.WriteLine(" {0} de 1.", contador_1);
			}
			
		}
		else
		{
			Console.WriteLine("Importe incorrecto");
		}
	}
}
		
		
		

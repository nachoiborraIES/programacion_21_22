/*
 * Practica 2: Programa que cuenta del primer al segundo numero de forma
 * ascendente o descendente segun cual sea el menor y cual el mayor.
 */

// Klavier Navarro
 
using System;
class Practica_2_2_1
{
	static void Main()
	{
		int num1, num2;
		Console.WriteLine("Dime un numero entero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro numero entero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if(num1 < num2)
        {
            for(; num1 <= num2; num1++)
            {
                Console.WriteLine(num1);
            }
        }
        
        else
        {
            for(; num1 >= num2; num1--)
            {
                Console.WriteLine(num1);
            }
        }
	}
}

/*
 * Programa que predefine un array de palabras, pide una frase de hasta 60
 * caracteres, si hay mas los corta y devuelve la frase centrada en la consola
 * con las palabras que no aparezcan en el array predefinido en color rojo.
 * 
 * Klavier Navarro
 */

using System;
public class Corrector
{
	static string PedirFrase() {
		string frase;
		
		Console.Write("Escribe una frase de hasta 60 carateres:");
		frase = Console.ReadLine();
		
		if(frase.Length > 60)
		{
			string fraseCortada = frase.Substring(0, 59);
			return fraseCortada;
		}
		
		else
			return frase;
	}
	
	static void CentrarYColorearFrase(string frase, string[] palabras) {
		Console.SetCursorPosition((Console.WindowWidth - frase.Length) / 2,1);
		string[] fraseArray = frase.Split();
		bool rojo;
		
		for(int i = 0; i < fraseArray.Length; i++)
		{
			rojo = true;
			
			for(int j = 0; j < palabras.Length; j++)
			{
				if(fraseArray[i] == palabras[j])
					rojo = false;
			}
			
			if(rojo)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(fraseArray[i] + " ");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write(fraseArray[i] + " ");
			}
		}
		Console.ForegroundColor = ConsoleColor.White;
	}
	
	static void Main() {
		string[] palabras = {"buenos", "dias", "tal", "tenga", "usted"};
		string frase;
		
		frase = PedirFrase();
		CentrarYColorearFrase(frase, palabras);
		
	}
}

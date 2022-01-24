/*Este ejercicio, tendrá dos funciones recursivas:
Una para comprobar si las cifras de un número son ascendentes y la otra que
intercambiara de un string las mayusculas por minusculas y viceversa*/

using System;
public class  Recursividad
{    
    // Alejandro Ribeiro
    
	static bool DigitosAscendentes(int entrada){
		if (entrada > 9){
			if (entrada % 10 >= (entrada / 10) % 10){
				return DigitosAscendentes(entrada / 10);
			}
			else{
				return false;
			}
		}
		return true;		
	}

    
    // Samuel Cano
    
    public static string TransformarTexto(string texto)
    {
        if (texto.Length < 1)
        {
            return texto;
        }        
        char letras = texto[0];
        string restante = texto.Substring(1);
        if (Char.IsLower(letras))
        {
            letras = Char.ToUpper(letras);
            
        }
        else
        {            
            letras = Char.ToLower(letras);            
        }
        return letras + TransformarTexto(restante);
    }
    
    static void Main()
	{       
        Console.WriteLine(DigitosAscendentes(123456789));
        Console.WriteLine(DigitosAscendentes(153496729));
        Console.WriteLine(DigitosAscendentes(2468));
        Console.WriteLine(DigitosAscendentes(7935));
        
        Console.WriteLine(TransformarTexto("Hola"));
        Console.WriteLine(TransformarTexto("hOLA"));
        Console.WriteLine(TransformarTexto("HoLa MunDo"));       
    }
}   

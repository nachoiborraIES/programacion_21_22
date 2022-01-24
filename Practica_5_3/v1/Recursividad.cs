using System;

// Agustín Sirvent

class Recursividad
{
    /*Vamos a hacer una función que mediante recursividad nos diga si el número está
     * ordenado en sentido ascendente o no.
     * Además, haremos otra función que invierta las mayúsculas y minúsculas de una cadena.
     * */
    public static bool DigitosAscendentes(int n)
    {
        if (n / 10 == 0)
        {
            return true;
        }

        return n % 10 >= n % 100 / 10 ? DigitosAscendentes(n / 10) : false;

    }

    public static string TransformarTexto(string cadena)
    {
        if (cadena.Length == 0)
        {
            return "";
        }

        return (Char.IsUpper(cadena[0]) ? cadena[0].ToString().ToLower() : cadena[0].ToString().ToUpper()) + TransformarTexto(cadena.Substring(1));
    }

    static void Main(string[] args)
    {
        Console.WriteLine(DigitosAscendentes(123456789));
        Console.WriteLine(DigitosAscendentes(98765432));
        Console.WriteLine(DigitosAscendentes(1122225678));
        Console.WriteLine(DigitosAscendentes(998876345));

        Console.WriteLine(TransformarTexto("Hola, como estas?"));
        Console.WriteLine(TransformarTexto("HoLa, Como eStAs?"));
        Console.WriteLine(TransformarTexto("HOLA, COMO ESTAS?"));
        Console.WriteLine(TransformarTexto("hola, como estas?"));
    }
}

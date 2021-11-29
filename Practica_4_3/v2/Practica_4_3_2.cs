/* Programa que tiene una lista de nombres , se ordena alfabeticamente 
 * de menora mayor y las empareje con todas las posibiliades, si no se 
 * puede, se enviara un mensaje de error. 
 * 
 * Enzo Nieto
 */
 
using System;
using System.Text;
class Ejercicio_05b_04
{
    static void Main()
    {
        bool sePuedeAgrupar = false;        
        int contador;
        Console.WriteLine("Nombres de invitados separados por coma: ");
        string[] invitados = Console.ReadLine().Split(',');
        Array.Sort(invitados);
        foreach (string invitado in invitados)
        {
            Console.Write(invitado + ", "); 
        }
        Console.WriteLine();
        int mitad = invitados.Length / 2;
        for (int i = 2; i <= mitad; i++)
        {
            if(invitados.Length % i == 0)
            {
                sePuedeAgrupar = true;
                contador = 0;
                Console.WriteLine("Grupos " + i);
                for (int j = 0; j < invitados.Length / i; j++)
                {
                    for (int y = 0; y < i; y++)
                    {
                        if(y > 0)
                        {
                            Console.Write("-");
                        }
                        Console.Write(invitados[contador]);
                        contador++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        if (!sePuedeAgrupar)
        {
            Console.WriteLine("No se puede emparejar");
        }
    }
}

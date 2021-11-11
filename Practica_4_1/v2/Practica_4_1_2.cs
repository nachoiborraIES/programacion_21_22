/*
 * Programa que pide al usuario el tamaño N (filas y columnas) de un array 
 * bidimensional (tabla), y cree una tabla de enteros de ese tamaño. 
 * Después, rellena cada uno de los valores de la tabla y, al finalizar, le 
 * dice si la tabla representa una matriz identidad (aquella donde todas las 
 * casillas son ceros, salvo las de la diagonal principal, aquellas donde la 
 * fila es igual a la columna que son unos) o no.
 * Por ejemplo, esto es una matriz identidad de tamaño 3:
 *                                                          1  0  0
 *                                                          0  1  0
 *                                                          0  0  1
 * Sila Sánchez Violero.
 * */
 
using System;

class Practica_4_1_2
{
    static void Main()
    {
        int tamanyoMatriz;
        int hay1 = 0, hay0 = 0;
    
        try
        {
            Console.Write("Introduce el tamaño de la matriz: ");
            tamanyoMatriz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            int[,] valores = new int[tamanyoMatriz, tamanyoMatriz];
          
            for(int i = 0; i < valores.GetLength(0); i++)
            {
                for(int j = 0; j < valores.GetLength(1); j++)
                {
                Console.Write(
                    "Introduce el valor de la fila {0} columna {1}: ", 
                        i +1, j +1);
                    valores[i, j] = Convert.ToInt32(Console.ReadLine());
                
                    if(i == j && valores[i, j] == 1) hay1++ ;
                    if(i != j && valores[i, j] == 0) hay0++ ;
                }
            }
                Console.WriteLine();
    
            for(int i = 0; i < valores.GetLength(0); i++)
            {
                for(int j = 0; j < valores.GetLength(1); j++)
                {
                    Console.Write(valores[i, j]);                 
                }
                Console.WriteLine();
            }
            
            if(hay1 == tamanyoMatriz && hay0 == (valores.Length - hay1))
            {
                Console.WriteLine();
                Console.WriteLine("Esto es una matriz identidad de tamaño {0}",
                    tamanyoMatriz);
            }             
            else
            {
                Console.WriteLine();
                Console.WriteLine("No es una matriz identidad");
            }          
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Se esperaba un valor de tipo entero.");
        }
        
    }
}










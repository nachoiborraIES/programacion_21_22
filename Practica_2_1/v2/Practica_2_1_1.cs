/*Pide al usuario tres temperaturas en grados centígrados
 * , y en función de los valores, conteste:
 * Más de 25 grados = Verano
 * Entre 15 y 25 = Primavera
 * Menos de 15 = Invierno */

// José Omar Ramírez

using  System;

class Practica_2_1_1
{
    static void Main ()
    {
        int grado1, grado2, grado3;
    
        Console.WriteLine ("Escribe la primera temperatura");
        grado1 = Convert.ToInt32(System.Console.ReadLine());
    
        Console.WriteLine ("Escribe la segunda temperatura");
        grado2 = Convert.ToInt32(System.Console.ReadLine());
    
        Console.WriteLine ("Escribe la tercera temperatura");
        grado3 = Convert.ToInt32(System.Console.ReadLine());
     
        if (grado1 > 25  && grado2 > 25 && grado3 > 25)
        {
            Console.WriteLine ("Es Verano");
        }
        else if (grado1 < 15  || grado2 < 15 || grado3 < 15)
        {
            Console.WriteLine ("Es Invierno");
        }
        else
        {
            Console.WriteLine ("Es Primavera u Otoño");
        }
   }
}

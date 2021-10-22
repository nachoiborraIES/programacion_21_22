/*Programa que calcula tu nota del primer trimestre, pidiendole al usuario 
 * primeramente el numero de notas de las prácticas realizadas, sumandolas y
 * haciendo una media de ellas y posteriormente pide las notas de los dos 
 * examenes para realizar el mismo proceso para, una vez obtenidas ambas medias,
 * calcular la nota final teniendo en cuenta que ambas deben ser superiores a
 * un 4 (en caso contrario se quedará con la inferior), y que la nota media de 
 * examenes es un 70% de la nota mientras que la de prácticas es un 30%.*/
 
// José Ignacio García

using System;

class Practica_3_1_1
{
	static void Main()
    {
		float practicas, notas, sumapracticas = 0, mediapracticas; 
		float e1, e2, mediaexamen, notafinal;
		int i = 0;
		
        Console.Write("Indica cuantas prácticas has realizado:");
        practicas = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Introduce la nota de tus {0} prácticas:", practicas);
		for(i = 1; i <= practicas; i++)
		{
			
			notas = Convert.ToSingle(Console.ReadLine());
			sumapracticas = notas + sumapracticas;
			
		}
		
		mediapracticas = sumapracticas/practicas;
		
        
        Console.WriteLine("Introduce las notas de tu primer examen:");
        e1 = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Introduce las notas de tu segundo examen:");
        e2 = Convert.ToSingle(Console.ReadLine());
        
        mediaexamen = (e1 + e2)/2;
        
        if(mediapracticas >= 4 && mediaexamen >= 4)
        {
			notafinal = (mediaexamen*70)/100 + (mediapracticas*30)/100;
		}
		
		else
        {
			notafinal = Math.Min(mediaexamen, mediapracticas);
		}
       
        Console.WriteLine("Tu nota final es {0}:", notafinal.ToString("N2"));
    }
}

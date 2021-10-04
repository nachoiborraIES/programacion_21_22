/*Usuario intruduce su nota de exámen y de prácticas y calculamos su nota final*/
// Samuel Cano

using System;
class Practica_1_1_1
{
    static void Main()
	{
		int examen, practicas, mediaexamen, mediapracticas, mediatotal;
		
		Console.WriteLine("Introduce su nota de exámen");
		examen = System.Convert.ToInt32(System.Console.ReadLine());
		
		Console.WriteLine("Introduce su nota de practicas");
		practicas = System.Convert.ToInt32(System.Console.ReadLine());
		
		mediaexamen = examen*7/10;
		mediapracticas = practicas*3/10;
		mediatotal = mediaexamen + mediapracticas;
			
		Console.WriteLine("Su nota final es de {0}", mediatotal); 
		
    }
}

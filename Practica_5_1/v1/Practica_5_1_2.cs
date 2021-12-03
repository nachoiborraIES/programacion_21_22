/* Matias Agustín Piombo
 * 
 * Programa para calcular la media, mediana y moda desde un módulo.
 */


using System;

class Practica_5_1_2{

	static void Main(){

		int[] numeros = { 3, 8, 6, 17, 4, 2, 9, 3, 10, 12, 9, 3, 2, 10};
		float media;
		int mediana, moda;

		CalcularEstadisticas(numeros, out media, out mediana, out moda);
		
		Console.WriteLine("Media: {0}, Mediana: {1}, Moda: {2}", media, mediana, moda);
	} 
	
	static void CalcularEstadisticas(int[] nums, out float media, out int mediana, out int moda){
		
		int[] nums2 = new int[nums.Length];
		
		media=0;
		mediana=0;
		moda=0;
		
		for(int i=0; i<nums.Length; i++){
			nums2[i]=nums[i];
		}
	
		Array.Sort(nums2);
		
		media=calcMedia(nums2, media);
		mediana=calcMediana(nums2, mediana);
		moda=calcModa(nums2, moda);

	}
	
	static float calcMedia(int[] nums2, float media){
		media=0;
		for(int i=0; i<nums2.Length; i++){
			media+=(float)nums2[i];
		}
		media/=nums2.Length; 
		return media;
	}
	
	static int calcMediana(int[] nums2, int mediana){
		mediana=nums2[nums2.Length/2];
		return mediana;
	}
	
	static int calcModa(int[] nums2, int moda){
		int cont=0, antCont=0;
		int antModa=0;
		for(int i=0; i<nums2.Length; i++){
			moda=nums2[i];
			cont=1;
			for(int j=i+1;j<nums2.Length;j++){
				if(moda == nums2[j])
					cont++;		
			}
			if(cont > antCont){
				antModa = moda;
				antCont = cont;
			}
		}
		return antModa;
	}
}

/*
 * Este programa es una ampliación de la practica anterior, en esta versión 
 * añadiremos 2 nuevas opciones las cuales son ordernar alfabeticamente 
 * ascendente y ordenar por forma descendente.
 * 
 * Daniel Marín Giner
 */
 
using System;

class Practica_4_3_1
{
	struct calificacion
	{
		public float teoria;
		public float practicas;
	}
	
	struct alumno
	{
		public string nombre;
		public string email;
		public calificacion notas;
	}
	
	enum opciones { SALIR, NUEVO, BORRAR, VER, APROBADOS, BUSCAR, 
		ALFABETICAMENTE, NOTA }	
	
	static void Main()
	{
		alumno[] alumnos = new alumno[50];
		alumno nuevoAlumno;
		int cantidad = 0, opcion, posicion;
		string alumnoABuscar;
		char confirmar;
		bool hayResultados;
		
		do
		{
			Console.WriteLine("Menú de opciones:");
			Console.WriteLine((int)opciones.NUEVO + 
				". Nuevo alumno");
			Console.WriteLine((int)opciones.BORRAR + 
				". Borrar alumno");
			Console.WriteLine((int)opciones.VER + 
				". Ver alumnos");
			Console.WriteLine((int)opciones.APROBADOS + 
				". Mostrar alumnos aprobados");
			Console.WriteLine((int)opciones.BUSCAR + 
				". Buscar alumnos por nombre");
			Console.WriteLine((int)opciones.ALFABETICAMENTE + 
				". Ordena alfabéticamente el listado.");
			Console.WriteLine((int)opciones.NOTA + 
				". Ordena por nota el listado.");
			Console.WriteLine((int)opciones.SALIR + 
				". Salir");
			Console.WriteLine("Elige una opción del menú:");
			
			opcion = Convert.ToInt32(Console.ReadLine());
			
			switch((opciones)opcion)
			{
				case opciones.NUEVO:
				
					if (cantidad < alumnos.Length)
					{
                        try
                        {
                            Console.WriteLine("Escribe el nombre del alumno:");
                            nuevoAlumno.nombre = Console.ReadLine();
                            Console.WriteLine("Escribe el email del alumno:");
                            nuevoAlumno.email = Console.ReadLine();
                            Console.WriteLine("Escribe la nota de teoría:");
                            nuevoAlumno.notas.teoria = 
                                Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Escribe la nota de prácticas:");
                            nuevoAlumno.notas.practicas = 
                                Convert.ToInt32(Console.ReadLine());
                                
                            if(nuevoAlumno.notas.teoria < 0 || 
                                nuevoAlumno.notas.teoria > 10 ||
                                nuevoAlumno.notas.practicas < 0 ||
                                nuevoAlumno.notas.practicas >10)
                            {
                                Console.WriteLine("Nota incorrecta:");
                            }
                            else
                            {
                                alumnos[cantidad] = nuevoAlumno;
                                cantidad++;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Datos incorrectos");
                        }
					}
                    else
                    {
                        Console.WriteLine("No caben más alumnos");
                    }
			
					break;
					
				case opciones.BORRAR:
                
					if(cantidad > 0)
					{
						Console.WriteLine("Introduce una posición a borrar");
						posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;
						
						if(posicion >= 0 && posicion < cantidad)
						{
							Console.WriteLine("¿Confirmar borrado? S/N");
							confirmar = 
                                Convert.ToChar(Console.ReadLine().ToUpper());
							
							if(confirmar == 'S')
							{
								Console.WriteLine("Posición borrada");
								for (int i = posicion; i < cantidad - 1; i++)
                                {
                                    alumnos[i] = alumnos[i+1];
                                }
								cantidad--;
							}							
							else
							{
								Console.WriteLine("Borrado cancelado");
							}
						}
						else
						{
							Console.WriteLine("Posición incorrecta");
						}
					}
					else
					{
						Console.WriteLine("No hay alumnos para borrar");
					}	
					break;
								
				case opciones.VER:
                
					if(cantidad > 0)
					{						
						for(int i = 0; i < cantidad; i++)
						{
							Console.WriteLine("{0} - {1} - {2} - {3}", 
								alumnos[i].nombre, alumnos[i].email, 
								alumnos[i].notas.teoria, 
								alumnos[i].notas.practicas);
						}
					}					
					else
					{
						Console.WriteLine("No hay alumnos guardados");
					}			
					break;
					
				case opciones.APROBADOS:
                
                    hayResultados = false;
					for(int i = 0; i < cantidad; i++)
					{
						if(alumnos[i].notas.teoria >= 4 && 
							alumnos[i].notas.practicas >= 4 && 
							alumnos[i].notas.teoria * 0.7 + 
							alumnos[i].notas.practicas * 0.3 >= 5)
						{
							Console.WriteLine("{0} - {1} - {2} - {3}", 
                                alumnos[i].nombre, alumnos[i].email, 
                                alumnos[i].notas.teoria, 
                                alumnos[i].notas.practicas);
                            hayResultados = true;
						}
					}			
                    
                    if (!hayResultados)
                    {
                        Console.WriteLine("No se han encontrado coincidencias");	
                    }
					break;
					
				case opciones.BUSCAR:
                
					Console.WriteLine("Escribe el nombre del alumno:");
					alumnoABuscar = Console.ReadLine();
					hayResultados = false;
					
					for(int i = 0; i < cantidad; i++)
					{
						if(alumnos[i].nombre.ToUpper()
                           .Contains(alumnoABuscar.ToUpper()))
						{							
							Console.WriteLine("{0} - {1} - {2} - {3}", 
                                alumnos[i].nombre, alumnos[i].email, 
                                alumnos[i].notas.teoria, 
                                alumnos[i].notas.practicas);
							hayResultados = true;							
						}
					}
					
					if(!hayResultados)
					{
                        Console.WriteLine("No se han encontrado coincidencias");	
					}
					
					break;
					
				case opciones.SALIR:
                
					Console.WriteLine("Fin del programa");
					break;
					
				case opciones.NOTA:
					
					for (int i = 0; i < cantidad; i++)
					{
						for (int j = 0; j < cantidad - i - 1; j++)
						{
							if (
								alumnos[j].notas.teoria < 
								alumnos[j+1].notas.teoria)
							{
								alumno auxiliar = alumnos[j];
								alumnos[j] = alumnos[j+1];
								alumnos[j+1] = auxiliar;
							}
						}
					}					
					for(int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("{0} - {1} - {2} - {3}", 
							alumnos[i].nombre, alumnos[i].email, 
							alumnos[i].notas.teoria, 
							alumnos[i].notas.practicas);
					}				

					
					break;
					
				case opciones.ALFABETICAMENTE:
					
					for(int i =0; i < cantidad; i++)
					{
						
						for(int j = i+1; j< cantidad; j++)
						{
							
							if(alumnos[i].nombre.ToUpper().CompareTo
							(alumnos[j].nombre.ToUpper())>0)
							{
							
								alumno auxiliar = alumnos[i];
								alumnos[i]=alumnos[j];
								alumnos[j]=auxiliar;
								
							}
							
						}
						
					}
					for(int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("{0} - {1} - {2} - {3}", 
							alumnos[i].nombre, alumnos[i].email, 
							alumnos[i].notas.teoria, 
							alumnos[i].notas.practicas);
					}
					break;
					
				default:
                
					Console.WriteLine("Opción incorrecta");
					break;				
			}
		}
		while(opcion != (int)opciones.SALIR);				
	}
}

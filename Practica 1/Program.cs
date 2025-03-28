/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 27/3/2025
 * Hora: 12:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	//Ejercicio 1
	public interface Comparable
	{
	bool sosIgual(Comparable c);
	
	bool sosMenor(Comparable c);
	
	bool sosMayor(Comparable c);
	}
	
	//Ejercicio 3
	public interface Coleccionable
	{
		int cuantos();
		
		Comparable minimo();
		
		Comparable maximo();
		
		void agregar(Comparable c);
		
		bool contiene(Comparable c);
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 7
			/*Pila pila = new Pila();
			Cola cola = new Cola();
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);*/
			//------------------------------------------------------
			
			//Ejercicio 9
			/*Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			informar(multiple);*/
			//------------------------------------------------------
			
			//Ejercicio 14
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			
			
			Console.ReadKey(true);
		}
		
		//Ejercicio 5
		public static void llenar(Coleccionable c)
		{
			Random random = new Random();
			for(int i = 0; i<20; i++)
			{
				c.agregar(new Numero(random.Next(1,50)));
			}
		}
		
		//Ejercicio 6 , Ejercicio 15 reimplementado
		public static void informar(ColeccionMultiple c)
		{
			Console.WriteLine("cantidad de elementos: "+c.cuantos());
			Console.WriteLine("el minimo es: "+c.minimo());
			Console.WriteLine("el maximo es: "+c.maximo());
			Console.WriteLine("ingrese un numero a buscar en la coleccion: ");
			int ingresado = int.Parse(Console.ReadLine());
			Alumno newAlumno = new Alumno("",0,ingresado,0);
			if(c.contiene(newAlumno))
				Console.WriteLine("el elemento ingresado existe en la colección.");
			else
				Console.WriteLine("el elemento ingresado no existe en la colección");
		}
		
		//Ejercicio 13
		
		public static void llenarAlumnos(Coleccionable c)
		{
			Random random = new Random();
			string [] nombres = { "" };
			
			for(int i = 0; i<20; i++)
			{
				string nombre = nombres[random.Next(nombres.Length)];
				int dni = random.Next(10,50);
				int legajo = random.Next(1,10);
				double promedio = ((int)(random.NextDouble() * 100));
				c.agregar(new Alumno(nombre,dni,legajo,promedio));
			}
		}
	}
	
	
}
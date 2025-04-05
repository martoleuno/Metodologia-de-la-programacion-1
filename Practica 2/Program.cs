/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 1/4/2025
 * Hora: 21:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	//Ejercicio 1
	public interface Comparable
	{
	bool sosIgual(Comparable c);
	
	bool sosMenor(Comparable c);
	
	bool sosMayor(Comparable c);
	}
	
	//Ejercicio 3
	public interface Coleccionable:Iterable
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
			//Ejercicio 7 (PRACTICA 1)
			/*Pila pila = new Pila();
			Cola cola = new Cola();
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);*/
			//------------------------------------------------------
			
			//Ejercicio 9 (PRACTICA 1)
			/*Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			informar(multiple);*/
			//------------------------------------------------------
			
			/*Ejercicio 7
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			llenarAlumnos(cola);
			llenarAlumnos(conjunto);
			ImprimirElementos(cola);
			Console.WriteLine("-------------------------------------");
			ImprimirElementos(conjunto);
			Console.WriteLine("-------------------------------------");*/
			
			
			//Ejercicio 9
			Pila pila = new Pila();
			llenarAlumnos(pila);
			informar(pila);
			ImprimirElementos(pila);
			Console.WriteLine("-------------------------------------");
			
			Console.ReadKey(true);
		}
		
		/*//Ejercicio 5
		public static void llenar(Coleccionable c)
		{
			Random random = new Random();
			for(int i = 0; i<20; i++)
			{
				c.agregar(new Numero(random.Next(1,50)));
			}
		}*/
		
		//Ejercicio 8 (implemento cambiar estrategia)
		public static void informar(Coleccionable c)
		{	
			Alumno a = new Alumno("",0,0,0);
			Console.WriteLine("que estrategia desea implementar? eliga la opcion que desee: ");
			Console.WriteLine("1. POR NOMBRES(MAS CORTO Y MAS LARGO)");
			Console.WriteLine("2. POR LEGAJO");
			Console.WriteLine("3. POR DNI");
			Console.WriteLine("4. POR PROMEDIO");
			int op = int.Parse(Console.ReadLine());

			switch (op)
			{
				case 1:
					cambiarEstrategia(c, new ComparacionPorNombre());
					Console.WriteLine("Alumnos ordenados por nombre (más corto y más largo): ");
					break;
				case 2:
					cambiarEstrategia(c, new ComparacionLegajo());
					Console.WriteLine("Alumnos ordenados por legajo: ");
					break;
				case 3:
					cambiarEstrategia(c, new ComparacionDNI());  // Corrección aquí
					Console.WriteLine("Alumnos ordenados por DNI: ");
					break;
				case 4:
					cambiarEstrategia(c, new ComparacionPromedio());
					Console.WriteLine("Alumnos ordenados por promedio: ");
					break;
			}
			
			Console.WriteLine("cantidad de elementos: "+c.cuantos());
			Console.WriteLine("el minimo es: "+c.minimo());
			Console.WriteLine("el maximo es: "+c.maximo());
		}
			
			/*if(c.contiene(newAlumno))
				Console.WriteLine("el elemento ingresado existe en la colección.");
			else
				Console.WriteLine("el elemento ingresado no existe en la colección");*/
		
		//Ejercicio 2 (Ej 13 modificado)
		
		public static void llenarAlumnos(Coleccionable c)
		{
			Random random = new Random();
			string [] nombres = { "laura","martin","jennifer","marcos","leandro","leo","candela" };
			
			for(int i = 0; i<20; i++)
			{
				string nombre = nombres[random.Next(nombres.Length)];
				int dni = random.Next(1000,5000);
				int legajo = random.Next(1,1000);
				double promedio = ((int)(random.NextDouble() * 10));
				Alumno a = new Alumno(nombre,dni,legajo,promedio);
				c.agregar(a);
			}
			
		}
		
		public static void ImprimirElementos(Coleccionable col)
		{
			Iterador ite = col.crearIterador();
			ite.primero();
			
			while(!ite.fin())
			{
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			
			Console.WriteLine("Final del recorrido!!");
		}
		
		
		public static void cambiarEstrategia(Coleccionable c, EstrategiaComparacion e)
		{
			Iterador i = c.crearIterador();
			i.primero();
			
			while (!i.fin())
			{
				Object actual = i.actual();

				if (actual is Alumno)
				{
					Alumno alum = (Alumno)actual;
					alum.setEstrategia(e);
				}

				i.siguiente();
			}
		}

	}
}

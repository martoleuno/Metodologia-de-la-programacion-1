/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 3/4/2025
 * Hora: 15:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	public class Conjunto:Coleccionable
	{
		//Ejercicio 3 y 4
		private List<Comparable> elementosConjunto;
		
		public Conjunto()
		{
			elementosConjunto = new List<Comparable>();
		}
		
		
		public Comparable getElementos(int index)
		{
			return elementosConjunto[index];
		}
		
		public void agregarElemento(Comparable c)
		{
			if(pertence(c))
			{
				Console.WriteLine("el elemento ya existe en la coleccion");
			}
			else
				agregar(c);
		}
		
		public bool pertence(Comparable c)
		{
			return contiene(c);
		}
		
		
		public int cuantos()
		{
			return elementosConjunto.Count;
		}
		
		public Comparable minimo()
		{
			Comparable maschico = elementosConjunto[0];
			for(int i = 1 ; i < cuantos(); i++)
			{
				if(elementosConjunto[i].sosMenor(maschico))
				{
					maschico = elementosConjunto[i];
				}
			}
			return maschico;
		}
		
		public Comparable maximo()
		{
			Comparable masgrande = elementosConjunto[0];
			for(int i = 1 ; i < cuantos(); i++)
			{
				if(elementosConjunto[i].sosMayor(masgrande))
				{
					masgrande = elementosConjunto[i];
				}
			}
			return masgrande;
		}
		
		public void agregar(Comparable c)
		{
			elementosConjunto.Add(c);
		}
		
		
		public bool contiene(Comparable c)
		{
			for(int i = 0 ; i < cuantos(); i++)
			{
				if(elementosConjunto[i].sosIgual(c))
				{
					return true;
				}
			}
			return false;
		}
		//Ejercicio 5
		public Comparable actual(int indice)
		{
			return elementosConjunto[indice];
		}
		
		
		public Iterador crearIterador()
		{
			return new IteradorConjunto(this);
		}
		
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 1/4/2025
 * Hora: 21:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	public class ColeccionMultiple//:Coleccionable
	{
		//Ejercicio 8 (PRACTICA 1)
		private Pila pila;
		private Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos()
		{	
			return pila.cuantos()+cola.cuantos();
		}
		
		
		public Comparable minimo()
		{
			Comparable minPila = pila.minimo();
			Comparable minCola = cola.minimo();
			
			if(minPila.sosMenor(minCola))
			{
				return minPila;
			}
			
			return minCola;
		}
		
		
		public Comparable maximo()
		{
			Comparable maxPila = pila.maximo();
			Comparable maxCola = cola.maximo();
			
			if(maxPila.sosMayor(maxCola))
			{
				return maxPila;
			}
			
			return maxCola;
		}
		
		
		public void agregar(Comparable c)
		{
		}
		
		
		public bool contiene(Comparable c)
		{
			return pila.contiene(c) & cola.contiene(c);
			
		}
		
		public void mostrar()
		{
			pila.mostrar();
			cola.mostrar();
		}
		
		
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 27/3/2025
 * Hora: 14:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_1
{
	
	public class Cola:Coleccionable
	{
		//Ejercicio 5
		private List<Comparable> elementos;
		
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		
		public void encolar(Comparable c)
		{
			elementos.Add(c);
		}
		
		public Comparable desencolar()
		{
			Comparable aux = elementos[0];
			elementos.RemoveAt(0);
			return aux;
		}
		
		
		public int cuantos()
		{
			return elementos.Count;
		}
		
		
		public Comparable minimo()
		{
			Comparable maschico = elementos[0];
			for(int i = 1 ; i < cuantos(); i++)
			{
				if(elementos[i].sosMenor(maschico))
				{
					maschico = elementos[i];
				}
			}
			return maschico;
		}
		
		
		public Comparable maximo()
		{
			Comparable masgrande = elementos[0];
			for(int i = 1 ; i < cuantos(); i++)
			{
				if(elementos[i].sosMayor(masgrande))
				{
					masgrande = elementos[i];
				}
			}
			return masgrande;
		}
		
		
		public void agregar(Comparable c)
		{
			encolar(c);
		}
		
		
		public bool contiene(Comparable c)
		{
			for(int i = 0 ; i < cuantos(); i++)
			{
				if(elementos[i].sosIgual(c))
				{
					return true;
				}
			}
			return false;
		}
	}
}

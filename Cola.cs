﻿/*
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
	public class Cola:Coleccionable
	{
		//Ejercicio 5
		private List<Comparable> elementos;
		
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		
		public Comparable getElementos(int index)
		{
			return elementos[index];
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
		
		public void mostrar()
		{
			foreach(Alumno c in elementos)
			{
				Console.WriteLine(c.getNombre);
				Console.WriteLine(c.getDni);
				Console.WriteLine(c.getPromedio);
				Console.WriteLine("-------------------------------------");
			}
		}
		//Ejercicio 5
		public Comparable actual(int indice)
		{
			return elementos[indice];
		}
		
		
		public Iterador crearIterador()
		{
			return new IteradorCola(this);
		}
	}
}

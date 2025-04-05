/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 4/4/2025
 * Hora: 12:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public class IteradorPila:Iterador
	{
		//Ejercicio 5 (PRACTICA 1)
		private Pila p;
		private int indice;
		
		public IteradorPila(Pila p)
		{
			this.p = p;
			this.primero();
		}
		
		
		public void primero()
		{
			indice = 0;
		}
		
		public void siguiente()
		{
			indice ++;
		}
		
		public bool fin()
		{
			return indice >= p.cuantos();
		}
		
		public Comparable actual()
		{
			return p.getElementos(indice);
		}
	}
}

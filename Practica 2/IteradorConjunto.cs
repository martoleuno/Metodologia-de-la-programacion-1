/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 4/4/2025
 * Hora: 13:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public class IteradorConjunto:Iterador
	{
		//Ejercicio 5
		private Conjunto conjunto;
		private int indice;
		
		public IteradorConjunto(Conjunto conjunto)
		{
			this.conjunto = conjunto;
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
			return indice >= conjunto.cuantos();
		}
		
		public Comparable actual()
		{
			return conjunto.getElementos(indice);

		}
	}
}

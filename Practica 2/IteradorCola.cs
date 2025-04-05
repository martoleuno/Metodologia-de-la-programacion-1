/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 4/4/2025
 * Hora: 13:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	
	public class IteradorCola:Iterador
	{
		private Cola c;
		private int indice;
		
		public IteradorCola(Cola c)
		{
			this.c = c;
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
			return indice >= c.cuantos();
		}
		
		public Comparable actual()
		{
			return c.getElementos(indice);
		}
	}
}

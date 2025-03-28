/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 27/3/2025
 * Hora: 13:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{

	public class Numero : Comparable
	{
		//Ejercicio 2
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
		public int getValor
		{
			get{return valor;}
			set{valor = value;}
		}
		
		public bool sosIgual(Comparable c)
		{
			return valor == ((Numero)c).valor;
		}
		
		public bool sosMenor(Comparable c)
		{
			return valor < ((Numero)c).valor;
		}
		
		public bool sosMayor(Comparable c)
		{
			return valor > ((Numero)c).valor;
		}
		
		public override string ToString()
		{
			return valor.ToString();
		}
		
	}
}

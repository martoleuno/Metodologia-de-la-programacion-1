/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 1/4/2025
 * Hora: 21:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public abstract class Persona:Comparable
	{
		//Ejercicio 11
		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre
		{
			get{return nombre;}
		}
		
		public int getDni
		{
			get{return dni;}
		}
		
		public virtual bool sosIgual(Comparable c)
		{
			return dni == ((Persona)c).getDni;
		}
		
		public virtual bool sosMenor(Comparable c)
		{
			return dni < ((Persona)c).getDni;
		}
		
		public virtual bool sosMayor(Comparable c)
		{
			return dni > ((Persona)c).getDni;
		}
		
		
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 27/3/2025
 * Hora: 19:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	public class Alumno:Persona
	{
		//Ejercicio 12 y reimplementacion del ejercicio 15 para que compare por legajo
		private int legajo;
		private double promedio;
		
		public Alumno(string n,int d,int l,double p):base(n,d)
		{
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
		}
		
		public int getLegajo
		{
			get{return legajo;}
		}
		
		public double getPromedio
		{
			get{return promedio;}
		}
		
		public override bool sosIgual(Comparable c)
		{
			return legajo == ((Alumno)c).getLegajo;
		}
		
		public override bool sosMenor(Comparable c)
		{
			return legajo < ((Alumno)c).getLegajo;
		}
		
		public override bool sosMayor(Comparable c)
		{
			return legajo > ((Alumno)c).getLegajo;
		}
		
		public override string ToString()
		{
			return legajo.ToString();
		}
	}
}

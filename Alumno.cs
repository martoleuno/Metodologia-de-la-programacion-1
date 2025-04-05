/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 1/4/2025
 * Hora: 21:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public class Alumno:Persona
	{
		//Ejercicio 1, aplicación de Estrategy en Alumno
		private int legajo;
		private double promedio;
		private EstrategiaComparacion estrategia;
		
		public Alumno(string n,int d,int l,double p):base(n,d)
		{
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new ComparacionPromedio();
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
			return estrategia.sosIgual(this, (Alumno)c);
		}
		
		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(this, (Alumno)c);
		}
		
		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(this, (Alumno)c);
		}
		
		public override string ToString()
		{
			
			return "DNI: "+dni.ToString()+" / LEGAJO:"+legajo.ToString()+" / NOMBRE:"+nombre.ToString()+" / PROMEDIO:"+promedio.ToString();
		
		}
		
		public void setEstrategia(EstrategiaComparacion newEstrategia)
		{
			estrategia = newEstrategia;
		}
	}
}

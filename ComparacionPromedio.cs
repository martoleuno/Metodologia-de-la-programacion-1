/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 2/4/2025
 * Hora: 21:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public class ComparacionPromedio:EstrategiaComparacion
	{
		//Ejercicio 1
		public ComparacionPromedio()
		{
		}
		
		public bool sosIgual(Alumno c1,Alumno c2)
		{
			return c1.getPromedio == ((Alumno)c2).getPromedio;
		}
		
		public bool sosMenor(Alumno c1,Alumno c2)
		{
			return c1.getPromedio < ((Alumno)c2).getPromedio;
		}
		
		public bool sosMayor(Alumno c1,Alumno c2)
		{
			return c1.getPromedio > ((Alumno)c2).getPromedio;
		}
	}
}

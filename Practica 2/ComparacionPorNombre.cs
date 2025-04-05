/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 2/4/2025
 * Hora: 21:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	
	public class ComparacionPorNombre:EstrategiaComparacion
	{
		//Ejercicio 1
		public ComparacionPorNombre()
		{
		}
		
		public bool sosIgual(Alumno c1,Alumno c2)
		{
			return c1.getNombre.Length == ((Alumno)c2).getNombre.Length;
		}
		
		public bool sosMenor(Alumno c1,Alumno c2)
		{
			return c1.getNombre.Length < ((Alumno)c2).getNombre.Length;
		}
		
		public bool sosMayor(Alumno c1,Alumno c2)
		{
			return c1.getNombre.Length > ((Alumno)c2).getNombre.Length;
		}
	}
}

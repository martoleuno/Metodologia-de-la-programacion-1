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
	public class ComparacionDNI:EstrategiaComparacion
	{
		//Ejercicio 1
		public ComparacionDNI()
		{
		}
		
		public bool sosIgual(Alumno c1,Alumno c2)
		{
			return c1.getDni == ((Alumno)c2).getDni;
		}
		
		public bool sosMenor(Alumno c1,Alumno c2)
		{
			return c1.getDni < ((Alumno)c2).getDni;
		}
		
		public bool sosMayor(Alumno c1,Alumno c2)
		{
			return c1.getDni > ((Alumno)c2).getDni;
		}
				
	
	}
}

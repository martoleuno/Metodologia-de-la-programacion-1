/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 2/4/2025
 * Hora: 20:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public class ComparacionLegajo:EstrategiaComparacion
	{
		//Ejercicio 1
		public ComparacionLegajo()
		{
		}
		
		public bool sosIgual(Alumno c1,Alumno c2)
		{
			return c1.getLegajo == ((Alumno)c2).getLegajo;
		}
		
		public bool sosMenor(Alumno c1,Alumno c2)
		{
			return c1.getLegajo < ((Alumno)c2).getLegajo;
		}
		
		public bool sosMayor(Alumno c1,Alumno c2)
		{
			return c1.getLegajo > ((Alumno)c2).getLegajo;
		}
		
	}
}

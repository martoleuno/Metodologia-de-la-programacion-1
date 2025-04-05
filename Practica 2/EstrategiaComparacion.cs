/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 2/4/2025
 * Hora: 20:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	//Ejercicio 1
	public interface EstrategiaComparacion
	{
		bool sosIgual(Alumno c1,Alumno c2);
		
		bool sosMenor(Alumno c1,Alumno c2);
		
		bool sosMayor(Alumno c1,Alumno c2);
	}
	
}

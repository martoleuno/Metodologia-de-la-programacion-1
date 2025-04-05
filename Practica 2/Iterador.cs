/*
 * Creado por SharpDevelop.
 * Usuario: marti
 * Fecha: 4/4/2025
 * Hora: 19:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	public interface Iterador
	{
		//Ejercicio 5
		void primero();
		
		void siguiente();
		
		bool fin();
		
		Comparable actual();
	}
}

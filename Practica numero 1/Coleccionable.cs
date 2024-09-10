/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 9/9/2024
 * Hora: 06:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_numero_1
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	
	public interface Coleccionable
	{
		int cuantos();
		int minimo();
		int maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}

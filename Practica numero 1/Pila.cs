/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 9/9/2024
 * Hora: 07:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_numero_1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila<T>
	{
		private List<T> elementos;
		
		
		public Pila()
		{
			elementos = new List<T>();
		}
		public List<T> getElementos(){
		
			return this.elementos;
		}
		
		public void apilar(T elem){
			this.elementos.Add(elem);
		}
		
		public T desapilar (){
			T UltimoE = (T)this.elementos[this.elementos.Count -1];
			this.elementos.RemoveAt(this.elementos.Count -1);
			return UltimoE;
		}
		public T tope(){
			return  (T)this.elementos[this.elementos.Count -1];
		}
		public bool estaVacia(){
			return this.elementos.Count == 0;
		}
	}
}

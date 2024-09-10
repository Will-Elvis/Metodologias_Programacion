/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 7/9/2024
 * Hora: 16:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_numero_1
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	
	public class Numero : Comparable
	{
		//atributos
		private int valor;
		
		//constructor
		public Numero(int v)
		{
			this.valor = v;
		}
		//metodo get de valor 
		public int getValor(){
			return this.valor;
		}
		
		//desarrollar metodos heredados de la interface de Comparable
		/*
		sosIgual(Comparable)  Devuelve verdadero si el objeto que recibe el mensaje
			 es el mismo que el “comparable” recibido por parámetro, devuelve falso en caso contrario
	 
		sosMenor(Comparable)  Devuelve verdadero si el objeto que recibe el mensaje es más 
			chico que el “comparable” recibido por parámetro, devuelve falso en caso contrario
	
		sosMayor(Comparable)  Devuelve verdadero si el objeto que recibe el mensaje es
	 		más grande que el “comparable” recibido por parámetro, devuelve falso en caso contrario
	 */
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).getValor();
		}
	}
}

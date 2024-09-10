/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 7/9/2024
 * Hora: 15:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_numero_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//INSTANCIAMOS NUMERO
			
			Numero n1 = new Numero(5);
			
			Numero n2 = new Numero(7);
			
			Console.WriteLine(n1.sosMenor(n2));
			
			
			// probamos pila 
			
			Pila<int> PilaE = new Pila<int>();
			
			PilaE.estaVacia();
			PilaE.apilar(2);
			PilaE.apilar(3);
			PilaE.apilar(5);
			PilaE.apilar(6);
			PilaE.apilar(7);
			PilaE.apilar(8);
			PilaE.apilar(9);
			PilaE.apilar(812);
			Console.WriteLine(PilaE.desapilar());
			Console.WriteLine(PilaE.tope());
			Console.WriteLine(PilaE.getElementos().Count);
			
			//Console.WriteLine(n2.GetType().Name);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
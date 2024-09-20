/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 05/09/2024
 * Hora: 21:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFormEstudiante.Clases
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		//atributos
		protected string paterno;
		protected string materno;
		protected string nombre;
		protected int Ci;
		//metodos constructor
		public Persona()
		{
		}
		//propiedades se obtiene de los atributos
		public string Paterno{
			get{return paterno;}
			set{paterno = value;}
		}
		public string Materno{
			get{return materno;}
			set{materno = value;}
		}
		public string Nombre{
			get{return nombre;}
			set{nombre = value;}
		}
		public int CI{
			get{return Ci;}
			set{Ci = value;}
		}
	}
}

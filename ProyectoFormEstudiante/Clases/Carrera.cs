/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 19/09/2024
 * Hora: 18:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFormEstudiante.Clases
{
	/// <summary>
	/// Description of Carrera.
	/// </summary>
	public class Carrera
	{
		private string  nombreCarrera;
		private string duracion;
		public Carrera()
		{
			
		}
		public string NombreCarrera{
			get{return nombreCarrera;}
			set{nombreCarrera = value;}
		}
		public string Duracion{
			get{return duracion;}
			set{duracion = value;}
		}
		
	}
}

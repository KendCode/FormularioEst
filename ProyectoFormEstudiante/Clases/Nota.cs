/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 05/09/2024
 * Hora: 21:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFormEstudiante.Clases
{
	/// <summary>
	/// Description of Nota.
	/// </summary>
	public class Nota
	{
		private double n1;
		private double n2;
		private double n3;
		private double promedio;
		private string obs;
		private double nmax;
		private double nmin;
		public Nota()
		{
		}
		public double Prom{
			get{return promedio;}
			set{promedio = value;}
		}
		public double NotaMax{
			get{return nmax;}
			set{nmax = value;}
		}
		public double NotaMin{
			get{return nmin;}
			set{nmin = value;}
		}
		public string Obs{
			get{return obs;}
			set{obs = value;}
		}
		public double N1{
			get{return n1;}
			set{n1 = value;}
		}
		public double N2{
			get{return n2;}
			set{n2 = value;}
		}
		public double N3{
			get{return n3;}
			set{n3 = value;}
		}
		//metodos
		//calcular la observacion
		//2da forma(llamada a metodos)
		public string Obs1(){
			double promedio = (n1+n2+n3)/3;
			if(promedio>=61)
				return "Aprobó";
			else
				return "Reprobó";
		}
	}
}

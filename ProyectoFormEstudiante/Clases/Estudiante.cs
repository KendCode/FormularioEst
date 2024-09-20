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
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante:Persona
	{
		private long matricula;
		private Nota No = new Nota();
		private Carrera Ca = new Carrera();
		public Estudiante():base()
		{
		}
		public long Matricula{
			get{return matricula;}
			set{matricula = value;}
		}
		public Nota NOTA{
			get{return No;}
			set{No = value;}
		}
		public Carrera CARRERA{
			get{return Ca;}
			set{Ca = value;}
		}
		//metodos
		//calcular el promedio de las notas
		// 1ra forma(get-set)
		public double Promedio(){
			double pro;
			pro = (No.N1+No.N2+No.N3)/3;
			return pro;
		}
		//calcular la observacion
		//2da forma(llamada a metodos)
		public string Obs2(){
			return No.Obs1();
		}
		//MOSTRAR DATOS
		public string Datos(){
			string dato = paterno+" "+materno+" "+nombre+" "+" con ci "+CI+" y matricula "+matricula;
			return dato;
		}
		public double Max(){
			double max;
			max = No.N1;
			if(No.N2 > max){
				max = No.N2;
			}
			if(No.N3 > max){
				max = No.N3;
			}
			return max;
			
		}
		public double Min(){
			double min=No.N1;
			if(No.N2 < min){
				min = No.N2;
			}
			if(No.N3 < min){
				min = No.N3;
			}
			return min;
		}
	}
}

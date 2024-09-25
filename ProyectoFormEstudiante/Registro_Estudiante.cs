/*
 * Creado por SharpDevelop.
 * Usuario: RAM
 * Fecha: 7/9/2024
 * Hora: 16:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFormEstudiante
{
	/// <summary>
	/// Description of Registro_Estudiante.
	/// </summary>
	/// 
	public partial class Registro_Estudiante : Form
	{
		int i=1;
		int posicion;
		int num;
		public Registro_Estudiante()
		{
			InitializeComponent();
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			Limpiar();
			btnAgregar.Enabled = true;
		}
		void Limpiar(){
			txt_Paterno.Clear();
			txt_Materno.Clear();
			txt_Nombre.Clear();
			txt_CI.Clear();
			txt_Matricula.Clear();
			txt_Nota1.Clear();
			txt_Nota2.Clear();
			txt_Nota3.Clear();
			txtCarrera.Clear();
			txtDuracion.Clear();
			txt_Paterno.Focus();
			btnModificar.Enabled = false;
			btnEliminar.Enabled= false;
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			Clases.Estudiante ES  = new Clases.Estudiante();
			ES.Paterno = txt_Paterno.Text;
			ES.Materno = txt_Materno.Text;
			ES.Nombre = txt_Nombre.Text;
			ES.CI = int.Parse(txt_CI.Text);
			ES.Matricula = int.Parse(txt_Matricula.Text);
			ES.NOTA.N1 = double.Parse(txt_Nota1.Text);
			ES.NOTA.N2 = double.Parse(txt_Nota2.Text);
			ES.NOTA.N3 = double.Parse(txt_Nota3.Text);
			ES.NOTA.Prom = ES.Promedio();
			ES.NOTA.Obs = ES.Obs2();
			ES.NOTA.NotaMax = ES.Max();
			ES.NOTA.NotaMin = ES.Min();
			ES.CARRERA.NombreCarrera = txtCarrera.Text;
			ES.CARRERA.Duracion = txtDuracion.Text;
			//index numero ------- item palabra
			ES.NOTA.Materia = cbbxMateria.SelectedItem.ToString();
			ES.CodigoMat(ES.NOTA.Materia);
			int auxgenero = cbbxGenero.SelectedIndex;
			ES.GeneroEst(auxgenero);
			//adicionar al DGV
			dgvEstudiantes.Rows.Add(i,ES.Paterno,ES.Materno,ES.Nombre,ES.CI,ES.Matricula,ES.Genero,ES.NOTA.N1,ES.NOTA.N2,
			                        ES.NOTA.N3,ES.NOTA.Prom,ES.NOTA.Obs,ES.NOTA.NotaMin,ES.NOTA.NotaMax,
			                        ES.CARRERA.NombreCarrera,ES.CARRERA.Duracion,ES.NOTA.Materia,ES.NOTA.CodMat);
			i++;
			Limpiar();
			
		}
		void Control(){
			i--;
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			dgvEstudiantes.Rows.RemoveAt(posicion);
			Limpiar();
			Numeracion();
			Control();
		}
		void Numeracion(){
			posicion = 0;
			for(int j=1; j<dgvEstudiantes.Rows.Count;j++){
				dgvEstudiantes[0,posicion].Value = j;
				posicion++;
				
			}
			
		}
		void DgvEstudiantesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			posicion = dgvEstudiantes.CurrentRow.Index;
			txt_Paterno.Text = dgvEstudiantes[1,posicion].Value.ToString();
			txt_Materno.Text = dgvEstudiantes[2,posicion].Value.ToString();
			txt_Nombre.Text = dgvEstudiantes[3,posicion].Value.ToString();
			txt_CI.Text = dgvEstudiantes[4,posicion].Value.ToString();
			txt_Matricula.Text = dgvEstudiantes[5,posicion].Value.ToString();
			txt_Nota1.Text = dgvEstudiantes[6,posicion].Value.ToString();
			txt_Nota2.Text = dgvEstudiantes[7,posicion].Value.ToString();
			txt_Nota3.Text = dgvEstudiantes[8,posicion].Value.ToString();
			txtCarrera.Text = dgvEstudiantes[13,posicion].Value.ToString();
			txtDuracion.Text= dgvEstudiantes[14,posicion].Value.ToString();
			btnAgregar.Enabled = false;
			btnModificar.Enabled =true;
			btnEliminar.Enabled = true;
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			dgvEstudiantes[1,posicion].Value = txt_Paterno.Text;
			dgvEstudiantes[2,posicion].Value = txt_Materno.Text;
			dgvEstudiantes[3,posicion].Value = txt_Nombre.Text;
			dgvEstudiantes[4,posicion].Value = txt_CI.Text;
			dgvEstudiantes[5,posicion].Value = txt_Matricula.Text;
			dgvEstudiantes[6,posicion].Value = txt_Nota1.Text;
			dgvEstudiantes[7,posicion].Value = txt_Nota2.Text;
			dgvEstudiantes[8,posicion].Value = txt_Nota3.Text;
			dgvEstudiantes[13,posicion].Value = txtCarrera.Text;
			dgvEstudiantes[14,posicion].Value = txtDuracion.Text;
			Limpiar();
		}
		
		void Txt_PaternoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64) && (e.KeyChar != ' ') || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir letras");
				e.Handled = true;
				return;
			}
		}
		void Txt_MaternoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64) && (e.KeyChar != ' ')  || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir letras");
				e.Handled = true;
				return;
			}
		}
		void Txt_NombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64) && (e.KeyChar != ' ')  || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir letras");
				e.Handled = true;
				return;
			}
		}
		void Txt_MatriculaKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255) ){ 
				MessageBox.Show("Error debe introducir numeros");
				e.Handled = true;
				return;
			}
		}
		void TxtCarreraKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64) && (e.KeyChar != ' ')  || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir letras");
				e.Handled = true;
				return;
			}
		}
		void Txt_Nota1KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255) ){
				MessageBox.Show("Error debe introducir numeros");
				e.Handled = true;
				return;
			}
		}
		void Txt_Nota2KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255) ){ 
				MessageBox.Show("Error debe introducir numeros");
				e.Handled = true;
				return;
			}
		}
		void Txt_Nota3KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255) ){ 
				MessageBox.Show("Error debe introducir numeros");
				e.Handled = true;
				return;
			}
		}
		void Txt_Nota1TextChanged(object sender, EventArgs e)
		{
			if(int.TryParse(txt_Nota1.Text,out num)){
				if(num <1 || num >100){
					MessageBox.Show("El numero debe ser entre 1 y 100");
					txt_Nota1.Clear();
				}
			}
		}
		void Txt_Nota2TextChanged(object sender, EventArgs e)
		{
			if(int.TryParse(txt_Nota2.Text,out num)){
				if(num <1 || num >100){
					MessageBox.Show("El numero debe ser entre 1 y 100");
					txt_Nota2.Clear();
				}
			}
		}
		void Txt_Nota3TextChanged(object sender, EventArgs e)
		{
			if(int.TryParse(txt_Nota3.Text,out num)){
				if(num <1 || num >100){
					MessageBox.Show("El numero debe ser entre 1 y 100");
					txt_Nota3.Clear();
				}
			}
		}
		void TxtDuracionKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64) && (e.KeyChar != ' ')  || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir letras");
				e.Handled = true;
				return;
			}
		}
		
		
		
	}
}

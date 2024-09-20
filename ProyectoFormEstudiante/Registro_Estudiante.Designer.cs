/*
 * Creado por SharpDevelop.
 * Usuario: RAM
 * Fecha: 7/9/2024
 * Hora: 16:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFormEstudiante
{
	partial class Registro_Estudiante
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_Paterno;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_Paterno;
		private System.Windows.Forms.Label lbl_Materno;
		private System.Windows.Forms.Label lbl_Nombre;
		private System.Windows.Forms.Label lbl_CI;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_Matricula;
		private System.Windows.Forms.Label lbl_Nota1;
		private System.Windows.Forms.TextBox txt_Materno;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.TextBox txt_CI;
		private System.Windows.Forms.TextBox txt_Matricula;
		private System.Windows.Forms.TextBox txt_Nota3;
		private System.Windows.Forms.TextBox txt_Nota2;
		private System.Windows.Forms.TextBox txt_Nota1;
		private System.Windows.Forms.Label lbl_Nota3;
		private System.Windows.Forms.Label lbl_Nota2;
		private System.Windows.Forms.DataGridView dgvEstudiantes;
		private System.Windows.Forms.DataGridViewTextBoxColumn nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn materno;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ci;
		private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota3;
		private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
		private System.Windows.Forms.DataGridViewTextBoxColumn obsevacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn notaMin;
		private System.Windows.Forms.DataGridViewTextBoxColumn notaMax;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtCarrera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
		private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
		private System.Windows.Forms.TextBox txtDuracion;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_Paterno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_Paterno = new System.Windows.Forms.Label();
			this.lbl_Materno = new System.Windows.Forms.Label();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.lbl_CI = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_Matricula = new System.Windows.Forms.Label();
			this.lbl_Nota1 = new System.Windows.Forms.Label();
			this.txt_Materno = new System.Windows.Forms.TextBox();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.txt_CI = new System.Windows.Forms.TextBox();
			this.txt_Matricula = new System.Windows.Forms.TextBox();
			this.txt_Nota3 = new System.Windows.Forms.TextBox();
			this.txt_Nota2 = new System.Windows.Forms.TextBox();
			this.txt_Nota1 = new System.Windows.Forms.TextBox();
			this.lbl_Nota3 = new System.Windows.Forms.Label();
			this.lbl_Nota2 = new System.Windows.Forms.Label();
			this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
			this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.obsevacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notaMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtCarrera = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDuracion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_Paterno
			// 
			this.txt_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Paterno.Location = new System.Drawing.Point(129, 90);
			this.txt_Paterno.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Paterno.Multiline = true;
			this.txt_Paterno.Name = "txt_Paterno";
			this.txt_Paterno.Size = new System.Drawing.Size(186, 32);
			this.txt_Paterno.TabIndex = 0;
			this.txt_Paterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PaternoKeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(218, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "REGISTRO ESTUDIANTE";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Datos Personales";
			// 
			// lbl_Paterno
			// 
			this.lbl_Paterno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Paterno.Location = new System.Drawing.Point(20, 90);
			this.lbl_Paterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Paterno.Name = "lbl_Paterno";
			this.lbl_Paterno.Size = new System.Drawing.Size(93, 30);
			this.lbl_Paterno.TabIndex = 3;
			this.lbl_Paterno.Text = "Paterno :";
			// 
			// lbl_Materno
			// 
			this.lbl_Materno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Materno.Location = new System.Drawing.Point(352, 90);
			this.lbl_Materno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Materno.Name = "lbl_Materno";
			this.lbl_Materno.Size = new System.Drawing.Size(86, 30);
			this.lbl_Materno.TabIndex = 4;
			this.lbl_Materno.Text = "Materno :";
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre.Location = new System.Drawing.Point(20, 152);
			this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(106, 26);
			this.lbl_Nombre.TabIndex = 5;
			this.lbl_Nombre.Text = "Nombre :";
			// 
			// lbl_CI
			// 
			this.lbl_CI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CI.Location = new System.Drawing.Point(352, 152);
			this.lbl_CI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_CI.Name = "lbl_CI";
			this.lbl_CI.Size = new System.Drawing.Size(74, 30);
			this.lbl_CI.TabIndex = 6;
			this.lbl_CI.Text = "CI";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 208);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(166, 30);
			this.label7.TabIndex = 7;
			this.label7.Text = "Datos Academicos";
			// 
			// lbl_Matricula
			// 
			this.lbl_Matricula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Matricula.Location = new System.Drawing.Point(20, 254);
			this.lbl_Matricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Matricula.Name = "lbl_Matricula";
			this.lbl_Matricula.Size = new System.Drawing.Size(93, 30);
			this.lbl_Matricula.TabIndex = 8;
			this.lbl_Matricula.Text = "Matricula ";
			// 
			// lbl_Nota1
			// 
			this.lbl_Nota1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nota1.Location = new System.Drawing.Point(20, 318);
			this.lbl_Nota1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Nota1.Name = "lbl_Nota1";
			this.lbl_Nota1.Size = new System.Drawing.Size(75, 30);
			this.lbl_Nota1.TabIndex = 9;
			this.lbl_Nota1.Text = "Nota 1";
			// 
			// txt_Materno
			// 
			this.txt_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Materno.Location = new System.Drawing.Point(448, 92);
			this.txt_Materno.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Materno.Multiline = true;
			this.txt_Materno.Name = "txt_Materno";
			this.txt_Materno.Size = new System.Drawing.Size(186, 32);
			this.txt_Materno.TabIndex = 17;
			this.txt_Materno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MaternoKeyPress);
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nombre.Location = new System.Drawing.Point(129, 152);
			this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Nombre.Multiline = true;
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(186, 32);
			this.txt_Nombre.TabIndex = 18;
			this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreKeyPress);
			// 
			// txt_CI
			// 
			this.txt_CI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_CI.Location = new System.Drawing.Point(448, 154);
			this.txt_CI.Margin = new System.Windows.Forms.Padding(2);
			this.txt_CI.MaxLength = 8;
			this.txt_CI.Multiline = true;
			this.txt_CI.Name = "txt_CI";
			this.txt_CI.Size = new System.Drawing.Size(186, 32);
			this.txt_CI.TabIndex = 19;
			// 
			// txt_Matricula
			// 
			this.txt_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Matricula.Location = new System.Drawing.Point(129, 254);
			this.txt_Matricula.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Matricula.Multiline = true;
			this.txt_Matricula.Name = "txt_Matricula";
			this.txt_Matricula.Size = new System.Drawing.Size(186, 32);
			this.txt_Matricula.TabIndex = 20;
			this.txt_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MatriculaKeyPress);
			// 
			// txt_Nota3
			// 
			this.txt_Nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nota3.Location = new System.Drawing.Point(530, 318);
			this.txt_Nota3.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Nota3.MaxLength = 3;
			this.txt_Nota3.Multiline = true;
			this.txt_Nota3.Name = "txt_Nota3";
			this.txt_Nota3.Size = new System.Drawing.Size(104, 32);
			this.txt_Nota3.TabIndex = 21;
			this.txt_Nota3.TextChanged += new System.EventHandler(this.Txt_Nota3TextChanged);
			this.txt_Nota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nota3KeyPress);
			// 
			// txt_Nota2
			// 
			this.txt_Nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nota2.Location = new System.Drawing.Point(310, 318);
			this.txt_Nota2.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Nota2.MaxLength = 3;
			this.txt_Nota2.Multiline = true;
			this.txt_Nota2.Name = "txt_Nota2";
			this.txt_Nota2.Size = new System.Drawing.Size(106, 32);
			this.txt_Nota2.TabIndex = 22;
			this.txt_Nota2.TextChanged += new System.EventHandler(this.Txt_Nota2TextChanged);
			this.txt_Nota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nota2KeyPress);
			// 
			// txt_Nota1
			// 
			this.txt_Nota1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nota1.Location = new System.Drawing.Point(99, 318);
			this.txt_Nota1.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Nota1.MaxLength = 3;
			this.txt_Nota1.Multiline = true;
			this.txt_Nota1.Name = "txt_Nota1";
			this.txt_Nota1.Size = new System.Drawing.Size(106, 32);
			this.txt_Nota1.TabIndex = 23;
			this.txt_Nota1.TextChanged += new System.EventHandler(this.Txt_Nota1TextChanged);
			this.txt_Nota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nota1KeyPress);
			// 
			// lbl_Nota3
			// 
			this.lbl_Nota3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nota3.Location = new System.Drawing.Point(450, 318);
			this.lbl_Nota3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Nota3.Name = "lbl_Nota3";
			this.lbl_Nota3.Size = new System.Drawing.Size(75, 30);
			this.lbl_Nota3.TabIndex = 24;
			this.lbl_Nota3.Text = "Nota 3";
			// 
			// lbl_Nota2
			// 
			this.lbl_Nota2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nota2.Location = new System.Drawing.Point(225, 318);
			this.lbl_Nota2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_Nota2.Name = "lbl_Nota2";
			this.lbl_Nota2.Size = new System.Drawing.Size(75, 30);
			this.lbl_Nota2.TabIndex = 25;
			this.lbl_Nota2.Text = "Nota 2";
			// 
			// dgvEstudiantes
			// 
			this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nro,
			this.paterno,
			this.materno,
			this.nombre,
			this.ci,
			this.matricula,
			this.nota1,
			this.nota2,
			this.nota3,
			this.promedio,
			this.obsevacion,
			this.notaMin,
			this.notaMax,
			this.carrera,
			this.duracion});
			this.dgvEstudiantes.Location = new System.Drawing.Point(651, 69);
			this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvEstudiantes.Name = "dgvEstudiantes";
			this.dgvEstudiantes.Size = new System.Drawing.Size(519, 310);
			this.dgvEstudiantes.TabIndex = 26;
			this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstudiantesCellContentClick);
			// 
			// nro
			// 
			this.nro.HeaderText = "Nro";
			this.nro.Name = "nro";
			// 
			// paterno
			// 
			this.paterno.HeaderText = "Paterno";
			this.paterno.Name = "paterno";
			// 
			// materno
			// 
			this.materno.HeaderText = "Materno";
			this.materno.Name = "materno";
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			// 
			// ci
			// 
			this.ci.HeaderText = "C.I.";
			this.ci.Name = "ci";
			// 
			// matricula
			// 
			this.matricula.HeaderText = "Matricula";
			this.matricula.Name = "matricula";
			// 
			// nota1
			// 
			this.nota1.HeaderText = "N1";
			this.nota1.Name = "nota1";
			// 
			// nota2
			// 
			this.nota2.HeaderText = "N2";
			this.nota2.Name = "nota2";
			// 
			// nota3
			// 
			this.nota3.HeaderText = "N3";
			this.nota3.Name = "nota3";
			// 
			// promedio
			// 
			this.promedio.HeaderText = "Promedio";
			this.promedio.Name = "promedio";
			// 
			// obsevacion
			// 
			this.obsevacion.HeaderText = "Observacion";
			this.obsevacion.Name = "obsevacion";
			// 
			// notaMin
			// 
			this.notaMin.HeaderText = "Nota Minima";
			this.notaMin.Name = "notaMin";
			// 
			// notaMax
			// 
			this.notaMax.HeaderText = "Nota Maxima";
			this.notaMax.Name = "notaMax";
			// 
			// carrera
			// 
			this.carrera.HeaderText = "Carrera";
			this.carrera.Name = "carrera";
			// 
			// duracion
			// 
			this.duracion.HeaderText = "Duración";
			this.duracion.Name = "duracion";
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnNuevo.Location = new System.Drawing.Point(651, 24);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(80, 26);
			this.btnNuevo.TabIndex = 27;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnAgregar.Location = new System.Drawing.Point(752, 24);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(108, 26);
			this.btnAgregar.TabIndex = 28;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnModificar.Location = new System.Drawing.Point(880, 24);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(99, 26);
			this.btnModificar.TabIndex = 29;
			this.btnModificar.Text = "MODIFICAR";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnEliminar.Location = new System.Drawing.Point(1008, 24);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(84, 26);
			this.btnEliminar.TabIndex = 30;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// txtCarrera
			// 
			this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarrera.Location = new System.Drawing.Point(448, 208);
			this.txtCarrera.Margin = new System.Windows.Forms.Padding(2);
			this.txtCarrera.Multiline = true;
			this.txtCarrera.Name = "txtCarrera";
			this.txtCarrera.Size = new System.Drawing.Size(186, 32);
			this.txtCarrera.TabIndex = 32;
			this.txtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCarreraKeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(339, 208);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 30);
			this.label3.TabIndex = 31;
			this.label3.Text = "Carrera";
			// 
			// txtDuracion
			// 
			this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDuracion.Location = new System.Drawing.Point(448, 254);
			this.txtDuracion.Margin = new System.Windows.Forms.Padding(2);
			this.txtDuracion.Multiline = true;
			this.txtDuracion.Name = "txtDuracion";
			this.txtDuracion.Size = new System.Drawing.Size(186, 32);
			this.txtDuracion.TabIndex = 34;
			this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDuracionKeyPress);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(339, 254);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 30);
			this.label4.TabIndex = 33;
			this.label4.Text = "Duración";
			// 
			// Registro_Estudiante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(1189, 424);
			this.Controls.Add(this.txtDuracion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCarrera);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.dgvEstudiantes);
			this.Controls.Add(this.lbl_Nota2);
			this.Controls.Add(this.lbl_Nota3);
			this.Controls.Add(this.txt_Nota1);
			this.Controls.Add(this.txt_Nota2);
			this.Controls.Add(this.txt_Nota3);
			this.Controls.Add(this.txt_Matricula);
			this.Controls.Add(this.txt_CI);
			this.Controls.Add(this.txt_Nombre);
			this.Controls.Add(this.txt_Materno);
			this.Controls.Add(this.lbl_Nota1);
			this.Controls.Add(this.lbl_Matricula);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbl_CI);
			this.Controls.Add(this.lbl_Nombre);
			this.Controls.Add(this.lbl_Materno);
			this.Controls.Add(this.lbl_Paterno);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Paterno);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Registro_Estudiante";
			this.Text = "Registro_Estudiante";
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

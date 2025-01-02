namespace Capa_Presentacion
{
    partial class Paciente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTurno = new System.Windows.Forms.Button();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxCondicion = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.tbxDni = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.EditarP = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelTurno = new System.Windows.Forms.Panel();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbxConsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelRegistro.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.PanelTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnTurno);
            this.panel1.Controls.Add(this.PanelRegistro);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbxBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.Color.Black;
            this.btnTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTurno.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnTurno.Image")));
            this.btnTurno.Location = new System.Drawing.Point(604, 0);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(108, 79);
            this.btnTurno.TabIndex = 4;
            this.btnTurno.UseVisualStyleBackColor = false;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.BackColor = System.Drawing.Color.Black;
            this.PanelRegistro.Controls.Add(this.flowLayoutPanel1);
            this.PanelRegistro.Controls.Add(this.cbxGenero);
            this.PanelRegistro.Controls.Add(this.dtpEdad);
            this.PanelRegistro.Controls.Add(this.panel12);
            this.PanelRegistro.Controls.Add(this.panel10);
            this.PanelRegistro.Controls.Add(this.panel9);
            this.PanelRegistro.Controls.Add(this.panel8);
            this.PanelRegistro.Controls.Add(this.panel7);
            this.PanelRegistro.Controls.Add(this.panel6);
            this.PanelRegistro.Controls.Add(this.panel5);
            this.PanelRegistro.Controls.Add(this.tbxCondicion);
            this.PanelRegistro.Controls.Add(this.tbxDireccion);
            this.PanelRegistro.Controls.Add(this.tbxTelefono);
            this.PanelRegistro.Controls.Add(this.tbxCorreo);
            this.PanelRegistro.Controls.Add(this.tbxDni);
            this.PanelRegistro.Controls.Add(this.tbxApellido);
            this.PanelRegistro.Controls.Add(this.tbxNombre);
            this.PanelRegistro.Controls.Add(this.lblDni);
            this.PanelRegistro.Controls.Add(this.lblTelefono);
            this.PanelRegistro.Controls.Add(this.lblCorreo);
            this.PanelRegistro.Controls.Add(this.lblDireccion);
            this.PanelRegistro.Controls.Add(this.lblGenero);
            this.PanelRegistro.Controls.Add(this.lblFechaNacimiento);
            this.PanelRegistro.Controls.Add(this.lblCondicion);
            this.PanelRegistro.Controls.Add(this.label1);
            this.PanelRegistro.Controls.Add(this.lblApellido);
            this.PanelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistro.Location = new System.Drawing.Point(37, 72);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(739, 512);
            this.PanelRegistro.TabIndex = 3;
            this.PanelRegistro.Visible = false;
            this.PanelRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegistro_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnEditar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(222, 387);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 79);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 76);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(108, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 76);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cbxGenero.Location = new System.Drawing.Point(222, 254);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(339, 28);
            this.cbxGenero.TabIndex = 12;
            // 
            // dtpEdad
            // 
            this.dtpEdad.CalendarForeColor = System.Drawing.Color.White;
            this.dtpEdad.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpEdad.Location = new System.Drawing.Point(222, 295);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(339, 26);
            this.dtpEdad.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel12.Location = new System.Drawing.Point(222, 361);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(339, 1);
            this.panel12.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(222, 234);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(339, 1);
            this.panel10.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(222, 197);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(339, 1);
            this.panel9.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(222, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(339, 1);
            this.panel8.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(222, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 1);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(222, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 1);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(222, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 1);
            this.panel5.TabIndex = 10;
            // 
            // tbxCondicion
            // 
            this.tbxCondicion.BackColor = System.Drawing.Color.Black;
            this.tbxCondicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCondicion.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxCondicion.Location = new System.Drawing.Point(222, 336);
            this.tbxCondicion.Name = "tbxCondicion";
            this.tbxCondicion.Size = new System.Drawing.Size(339, 19);
            this.tbxCondicion.TabIndex = 9;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.BackColor = System.Drawing.Color.Black;
            this.tbxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxDireccion.Location = new System.Drawing.Point(222, 214);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(339, 19);
            this.tbxDireccion.TabIndex = 9;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.BackColor = System.Drawing.Color.Black;
            this.tbxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxTelefono.Location = new System.Drawing.Point(222, 172);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(339, 19);
            this.tbxTelefono.TabIndex = 9;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.BackColor = System.Drawing.Color.Black;
            this.tbxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxCorreo.Location = new System.Drawing.Point(222, 135);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(339, 19);
            this.tbxCorreo.TabIndex = 9;
            // 
            // tbxDni
            // 
            this.tbxDni.BackColor = System.Drawing.Color.Black;
            this.tbxDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDni.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxDni.Location = new System.Drawing.Point(222, 92);
            this.tbxDni.Name = "tbxDni";
            this.tbxDni.Size = new System.Drawing.Size(339, 19);
            this.tbxDni.TabIndex = 9;
            // 
            // tbxApellido
            // 
            this.tbxApellido.BackColor = System.Drawing.Color.Black;
            this.tbxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxApellido.Location = new System.Drawing.Point(222, 55);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(339, 19);
            this.tbxApellido.TabIndex = 9;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.Black;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxNombre.Location = new System.Drawing.Point(222, 12);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(339, 19);
            this.tbxNombre.TabIndex = 9;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(171, 96);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 20);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(133, 174);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(147, 136);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(61, 20);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(129, 212);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(141, 256);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 20);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(46, 296);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(163, 20);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.ForeColor = System.Drawing.Color.White;
            this.lblCondicion.Location = new System.Drawing.Point(58, 336);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(150, 20);
            this.lblCondicion.TabIndex = 2;
            this.lblCondicion.Text = "Condicion de Salud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(147, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(712, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 79);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(85, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 3);
            this.panel3.TabIndex = 1;
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.BackColor = System.Drawing.Color.Black;
            this.tbxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxBuscar.Location = new System.Drawing.Point(85, 44);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(339, 19);
            this.tbxBuscar.TabIndex = 0;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.AllowUserToResizeRows = false;
            this.dgvPaciente.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarP,
            this.Eliminar});
            this.dgvPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaciente.GridColor = System.Drawing.Color.Black;
            this.dgvPaciente.Location = new System.Drawing.Point(0, 79);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvPaciente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvPaciente.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dgvPaciente.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaciente.Size = new System.Drawing.Size(820, 616);
            this.dgvPaciente.TabIndex = 1;
            this.dgvPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellClick);
            // 
            // EditarP
            // 
            this.EditarP.HeaderText = "";
            this.EditarP.Image = ((System.Drawing.Image)(resources.GetObject("EditarP.Image")));
            this.EditarP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarP.Name = "EditarP";
            this.EditarP.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 77);
            this.panel2.TabIndex = 2;
            // 
            // PanelTurno
            // 
            this.PanelTurno.BackColor = System.Drawing.Color.Black;
            this.PanelTurno.Controls.Add(this.dgvMed);
            this.PanelTurno.Controls.Add(this.maskedTextBox1);
            this.PanelTurno.Controls.Add(this.label2);
            this.PanelTurno.Controls.Add(this.flowLayoutPanel2);
            this.PanelTurno.Controls.Add(this.cbxEstado);
            this.PanelTurno.Controls.Add(this.dtpFecha);
            this.PanelTurno.Controls.Add(this.panel13);
            this.PanelTurno.Controls.Add(this.panel14);
            this.PanelTurno.Controls.Add(this.tbxConsulta);
            this.PanelTurno.Controls.Add(this.label3);
            this.PanelTurno.Controls.Add(this.label5);
            this.PanelTurno.Controls.Add(this.label6);
            this.PanelTurno.Controls.Add(this.label7);
            this.PanelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTurno.Location = new System.Drawing.Point(40, 129);
            this.PanelTurno.Name = "PanelTurno";
            this.PanelTurno.Size = new System.Drawing.Size(739, 512);
            this.PanelTurno.TabIndex = 4;
            this.PanelTurno.Visible = false;
            this.PanelTurno.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTurno_Paint);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(222, 56);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.ReadOnly = true;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(502, 70);
            this.dgvMed.TabIndex = 17;
            this.dgvMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(223, 192);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(340, 26);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seleccion de Medico:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardarTurno);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(222, 381);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(339, 79);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.BackColor = System.Drawing.Color.Black;
            this.btnGuardarTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardarTurno.FlatAppearance.BorderSize = 0;
            this.btnGuardarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnGuardarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTurno.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarTurno.Image")));
            this.btnGuardarTurno.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(99, 76);
            this.btnGuardarTurno.TabIndex = 0;
            this.btnGuardarTurno.UseVisualStyleBackColor = false;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(108, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 76);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Pendiente"});
            this.cbxEstado.Location = new System.Drawing.Point(219, 280);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(339, 28);
            this.cbxEstado.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpFecha.Location = new System.Drawing.Point(222, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(339, 26);
            this.dtpFecha.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel13.Location = new System.Drawing.Point(222, 258);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(339, 1);
            this.panel13.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel14.Location = new System.Drawing.Point(223, 223);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(339, 1);
            this.panel14.TabIndex = 10;
            // 
            // tbxConsulta
            // 
            this.tbxConsulta.BackColor = System.Drawing.Color.Black;
            this.tbxConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConsulta.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxConsulta.Location = new System.Drawing.Point(222, 233);
            this.tbxConsulta.Name = "tbxConsulta";
            this.tbxConsulta.Size = new System.Drawing.Size(339, 19);
            this.tbxConsulta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motivo de Consulta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(153, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha:";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTurno);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Paciente";
            this.Size = new System.Drawing.Size(820, 772);
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.PanelTurno.ResumeLayout(false);
            this.PanelTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxCondicion;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.TextBox tbxDni;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.DateTimePicker dtpEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn EditarP;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Panel PanelTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbxConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dgvMed;
    }
}

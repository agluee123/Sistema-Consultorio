namespace Capa_Presentacion
{
    partial class VistaTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaTurno));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.EditarP = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelTurno = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostio = new System.Windows.Forms.Label();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnModificar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.PanelTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbxBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 79);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(85, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 3);
            this.panel3.TabIndex = 6;
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
            this.tbxBuscar.TabIndex = 5;
            // 
            // dgvTurno
            // 
            this.dgvTurno.AllowUserToAddRows = false;
            this.dgvTurno.AllowUserToDeleteRows = false;
            this.dgvTurno.AllowUserToResizeRows = false;
            this.dgvTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurno.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarP,
            this.Eliminar});
            this.dgvTurno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTurno.GridColor = System.Drawing.Color.Black;
            this.dgvTurno.Location = new System.Drawing.Point(0, 79);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.ReadOnly = true;
            this.dgvTurno.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvTurno.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvTurno.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dgvTurno.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurno.Size = new System.Drawing.Size(820, 693);
            this.dgvTurno.TabIndex = 5;
            this.dgvTurno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurno_CellClick);
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
            // PanelTurno
            // 
            this.PanelTurno.BackColor = System.Drawing.Color.Black;
            this.PanelTurno.Controls.Add(this.panel2);
            this.PanelTurno.Controls.Add(this.tbxDiagnostico);
            this.PanelTurno.Controls.Add(this.lblDiagnostio);
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
            this.PanelTurno.Location = new System.Drawing.Point(41, 130);
            this.PanelTurno.Name = "PanelTurno";
            this.PanelTurno.Size = new System.Drawing.Size(739, 618);
            this.PanelTurno.TabIndex = 6;
            this.PanelTurno.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(221, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 1);
            this.panel2.TabIndex = 20;
            // 
            // tbxDiagnostico
            // 
            this.tbxDiagnostico.BackColor = System.Drawing.Color.Black;
            this.tbxDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiagnostico.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxDiagnostico.Location = new System.Drawing.Point(221, 347);
            this.tbxDiagnostico.Name = "tbxDiagnostico";
            this.tbxDiagnostico.Size = new System.Drawing.Size(339, 19);
            this.tbxDiagnostico.TabIndex = 19;
            // 
            // lblDiagnostio
            // 
            this.lblDiagnostio.AutoSize = true;
            this.lblDiagnostio.ForeColor = System.Drawing.Color.White;
            this.lblDiagnostio.Location = new System.Drawing.Point(99, 351);
            this.lblDiagnostio.Name = "lblDiagnostio";
            this.lblDiagnostio.Size = new System.Drawing.Size(97, 20);
            this.lblDiagnostio.TabIndex = 18;
            this.lblDiagnostio.Text = "Diagnostico:";
            // 
            // dgvMed
            // 
            this.dgvMed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(222, 56);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.ReadOnly = true;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(499, 105);
            this.dgvMed.TabIndex = 17;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(223, 214);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(340, 26);
            this.maskedTextBox1.TabIndex = 16;
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
            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(222, 422);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(339, 79);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(3, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 76);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Pendiente"});
            this.cbxEstado.Location = new System.Drawing.Point(219, 302);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(339, 28);
            this.cbxEstado.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpFecha.Location = new System.Drawing.Point(222, 172);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(339, 26);
            this.dtpFecha.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel13.Location = new System.Drawing.Point(222, 280);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(339, 1);
            this.panel13.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel14.Location = new System.Drawing.Point(223, 245);
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
            this.tbxConsulta.Location = new System.Drawing.Point(222, 255);
            this.tbxConsulta.Name = "tbxConsulta";
            this.tbxConsulta.Size = new System.Drawing.Size(339, 19);
            this.tbxConsulta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motivo de Consulta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(153, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha:";
            // 
            // VistaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTurno);
            this.Controls.Add(this.dgvTurno);
            this.Controls.Add(this.panel1);
            this.Name = "VistaTurno";
            this.Size = new System.Drawing.Size(820, 772);
            this.Load += new System.EventHandler(this.VistaTurno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.PanelTurno.ResumeLayout(false);
            this.PanelTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.DataGridViewImageColumn EditarP;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel PanelTurno;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbxConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxDiagnostico;
        private System.Windows.Forms.Label lblDiagnostio;
    }
}

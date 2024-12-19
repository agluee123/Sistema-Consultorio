namespace Capa_Presentacion
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.PanelBienvenida = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPadre.SuspendLayout();
            this.PanelBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnTurno);
            this.panel1.Controls.Add(this.btnMedico);
            this.panel1.Controls.Add(this.btnPaciente);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 722);
            this.panel1.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 340);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(259, 81);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurno.ForeColor = System.Drawing.Color.Black;
            this.btnTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnTurno.Image")));
            this.btnTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.Location = new System.Drawing.Point(0, 259);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(259, 81);
            this.btnTurno.TabIndex = 2;
            this.btnTurno.Text = "Turnos";
            this.btnTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTurno.UseVisualStyleBackColor = false;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.Color.Black;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.Location = new System.Drawing.Point(0, 179);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(259, 80);
            this.btnMedico.TabIndex = 1;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 100);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(259, 79);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 100);
            this.panel3.TabIndex = 0;
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.panelPadre.Controls.Add(this.PanelBienvenida);
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(259, 0);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(884, 722);
            this.panelPadre.TabIndex = 1;
            // 
            // PanelBienvenida
            // 
            this.PanelBienvenida.Controls.Add(this.label1);
            this.PanelBienvenida.Location = new System.Drawing.Point(31, 114);
            this.PanelBienvenida.Name = "PanelBienvenida";
            this.PanelBienvenida.Size = new System.Drawing.Size(827, 326);
            this.PanelBienvenida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 326);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Consultorio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 722);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelPadre.ResumeLayout(false);
            this.PanelBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel PanelBienvenida;
        private System.Windows.Forms.Label label1;
    }
}


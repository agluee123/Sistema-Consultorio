using Capa_Dominio;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        private string rolUsuario;

        public Form1()
        {
            InitializeComponent();
            //PanelSesion.BringToFront();
            //PanelSesion.Dock = DockStyle.Fill;
        }

        public Form1(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
            ConfigurarPermisos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;
            //ConfigurarPermisos(rolUsuario);
        }

        private void ConfigurarPermisos()
        {
            btnMedico.Visible = false;
            btnPaciente.Visible = false;
            btnUsuarios.Visible = false;
            btnTurno.Visible = false;
            btnCerrarSesion.Visible = false;

            // Habilitar botones dependiendo del rol
            if (rolUsuario == "Admin")
            {
                btnMedico.Visible = true;     
                btnPaciente.Visible = true; 
                btnTurno.Visible = true;
                btnUsuarios.Visible = true;
                btnCerrarSesion.Visible=true;

            }
            else if (rolUsuario  == "Medico")
            {
                btnTurno.Visible = true;
                btnCerrarSesion.Visible = true;
                btnPaciente.Visible=true;

            }
            else if (rolUsuario  == "Recepcionista")
            {
                btnTurno.Visible = true;
                btnPaciente.Visible = true;
                btnCerrarSesion.Visible = true;
                // El Recepcionista tiene permisos limitados
                // No habilitamos botones adicionales
            } 
        }

        private void ConfigurarPermisosEnControles()
        {
            foreach (Control control in panelPadre.Controls) // Recorremos los controles dentro del Panel
            {
                if (control is Paciente pacienteControl) // Verificamos si es el UserControl Paciente
                {
                    pacienteControl.DeshabilitarBotones(rolUsuario); // Llamamos al método del UserControl
                }
            }

        }


        private void btnPaciente_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Paciente control = new Paciente();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);

            // 🔹 Aplicar permisos en el UserControl recién agregado
            control.DeshabilitarBotones(rolUsuario);
        }


        private void btnMedico_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            VistaMedico control = new VistaMedico();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);

        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            VistaTurno control = new VistaTurno();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
            control.DeshabilitarBotones(rolUsuario);

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            VistaUsuarios control= new VistaUsuarios();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Ocultar MenuPrincipal
            IniciarSesion login = new IniciarSesion();


            if (login.ShowDialog() == DialogResult.OK)
            {
                // Si inicia sesión, actualizar el rol y mostrar el menú otra vez
                string nuevoRol = login.RolUsuario;
                Form1 nuevoMenu = new Form1(nuevoRol);
                nuevoMenu.Show();
            }

            this.Close(); // Cerrar la instancia actual del formulario
        }

        
    }
}

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
            PanelSesion.BringToFront();
            PanelSesion.Dock = DockStyle.Fill;
        }

        public Form1(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;  
        }

        
        private void ConfigurarPermisos(string rol)
        {
            // Deshabilitar todos los botones inicialmente
            btnMedico.Enabled = false;
            btnPaciente.Enabled = false;
            btnUsuarios.Enabled = false;
            btnTurno.Enabled = false;    

            // Habilitar botones dependiendo del rol
            if (rol == "Admin")
            {
                btnMedico.Enabled = true;     
                btnPaciente.Enabled = true; 
                btnTurno.Enabled = true;
                btnUsuarios.Enabled = true;
            }
            else if (rol == "Medico")
            {
                btnTurno.Enabled = true;       // El Medico puede acceder a los turnos
            }
            else if (rol == "Recepcionista")
            {
                //btnTurno.Enabled = true;
                //btnPaciente.Enabled = true;
                // El Recepcionista tiene permisos limitados
                // No habilitamos botones adicionales
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Paciente control = new Paciente();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
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

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            VistaUsuarios control= new VistaUsuarios();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           UsuarioNegocio negocio = new UsuarioNegocio();
            string usuario=tbxUsuario.Text;
            string contraseña=tbxContraseña.Text;

            string resultado = negocio.AutenticarUsuario(usuario, contraseña);

            if (resultado == "Recepcionista" || resultado == "Medico" || resultado=="Admin")
            {
                PanelSesion.Visible = false;
                panelPadre.Visible = true;

                ConfigurarPermisos(resultado);

                MessageBox.Show("Bienvenido, " + resultado);

            }
            else
            {
                MessageBox.Show(resultado);
            }


        }
    }
}

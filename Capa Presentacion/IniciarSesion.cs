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
using Capa_Presentacion;

namespace Capa_Presentacion
{
    public partial class IniciarSesion : Form
    {
        public string RolUsuario { get; private set; }
        public IniciarSesion()
        {
            InitializeComponent();
        }

        public IniciarSesion(string rol)
        {
        }
        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            this.Show();
            tbxContraseña.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            string usuario = tbxUsuario.Text;
            string contraseña = tbxContraseña.Text;

            string resultado = negocio.AutenticarUsuario(usuario, contraseña);

            if (resultado == "Recepcionista" || resultado == "Medico" || resultado == "Admin")
            {
                RolUsuario=resultado;
                this.DialogResult = DialogResult.OK; // Indicar que el login fue exitoso
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
            }
        }
    }
}

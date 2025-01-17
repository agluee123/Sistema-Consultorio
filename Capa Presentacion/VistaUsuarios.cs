using Capa_Dominio;
using Capa_Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class VistaUsuarios : UserControl
    {
        private List<Usuario> lista;
        public VistaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PanelUsuario.Visible = true;
            PanelUsuario.Dock = DockStyle.Fill;
        }

      
        private void CargarDatos()
        {

            try
            {
                lista = new UsuarioNegocio().listar();
                dgvUsuarios.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                nuevo.Nombre = tbxNombre.Text;
                nuevo.Dni = tbxDni.Text;
                nuevo.UsuarioNombre = tbxUsuario.Text;
                nuevo.Contraseña = tbxContraseña.Text;
                nuevo.Rol = cbxRol.SelectedItem?.ToString();
                negocio.Agregar(nuevo);

                MessageBox.Show("Usuario creado correctamente." + nuevo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                nuevo.Nombre = tbxNombre.Text;
                nuevo.Dni = tbxDni.Text;
                nuevo.UsuarioNombre = tbxUsuario.Text;
                nuevo.Contraseña = tbxContraseña.Text;
                nuevo.Rol = cbxRol.SelectedItem?.ToString();
                negocio.Agregar(nuevo);

                MessageBox.Show("Usuario creado correctamente." + nuevo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

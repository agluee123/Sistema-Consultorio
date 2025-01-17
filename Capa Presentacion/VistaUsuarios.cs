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
        int id_usuario;
        public VistaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PanelUsuario.Visible = true;
            PanelUsuario.Dock = DockStyle.Fill;
            btnEditar.Visible = false;
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTurno.Columns["EditarP"].Index)
            {
                ObtenerUsuarioEditar(e.RowIndex);
                PanelUsuario.Dock = DockStyle.Fill;

            }
        }

        private void ObtenerUsuarioEditar(int rowIndex)
        {
            try
            {
                id_usuario = Convert.ToInt32(dgvUsuarios.Rows[rowIndex].Cells[2].Value);
                tbxNombre.Text = dgvUsuarios.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                tbxDni.Text = dgvUsuarios.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                tbxUsuario.Text = dgvUsuarios.Rows[rowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                tbxContraseña.Text = dgvUsuarios.Rows[rowIndex].Cells[6].Value?.ToString() ?? string.Empty;
                cbxRol.Text = dgvUsuarios.Rows[rowIndex].Cells[7].Value?.ToString() ?? string.Empty;
                PanelUsuario.Visible = true;
                PanelUsuario.Dock = DockStyle.Fill;
                btnGuardarUsuario.Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
    

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario editar=new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                //editar.IdUsuario = id_usuario;
                MessageBox.Show("el id es" + id_usuario);
                editar.Nombre = tbxNombre.Text;
                editar.Dni = tbxDni.Text;
                editar.UsuarioNombre = tbxUsuario.Text;
                editar.Contraseña = tbxContraseña.Text;
                editar.Rol = cbxRol.SelectedItem?.ToString();

                negocio.Modificar(editar);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

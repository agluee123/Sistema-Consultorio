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
            DiseñoDgv(ref dgvUsuarios);
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
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvTurno.Columns["Eliminar"].Index)
            {

                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este Usuario?",
                    "Confirmación de Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                   
                    try
                    {
                        UsuarioNegocio usuario = new UsuarioNegocio();
                        DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                        int id_usuario = Convert.ToInt32(row.Cells["IdUsuario"].Value);
                        usuario.EliminarUsuario(id_usuario);
                        // Mostrar mensaje de éxito
                        MessageBox.Show("Usuario eliminado correctamente." , "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            Usuario editar = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            UsuarioNegocio negocio=new UsuarioNegocio();
            try
            {
                editar.Nombre = tbxNombre.Text;
                editar.Dni = tbxDni.Text;
                editar.UsuarioNombre = tbxUsuario.Text;
                editar.Contraseña = tbxContraseña.Text;
                editar.Rol = cbxRol.SelectedItem?.ToString();
                
                negocio.Modificar(editar);
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelUsuario.Visible=false; 
                CargarDatos();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DiseñoDgv(ref DataGridView dgv)
        {

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;


            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor;


            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            List<Usuario> lista = negocio.listar();
            List<Usuario> listaFiltrada;
            string filtro = tbxBuscar.Text.ToUpper(); // Convertir el filtro a mayúsculas una vez

            if (filtro.Length >= 1)
            {
                listaFiltrada = lista.FindAll(x =>
                 x.Nombre.ToUpper().Contains(filtro) || x.Rol.ToString().Contains(filtro)); // Filtrar por nombre que contiene el filtro

            }
            else
            {
                listaFiltrada = lista;
            }

            dgvUsuarios.DataSource = listaFiltrada;
        }
    }
}

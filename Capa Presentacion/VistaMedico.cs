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
using System.Collections;
using Capa_Dominio;
using Capa_Negocio;


namespace Capa_Presentacion
{
    public partial class VistaMedico : UserControl
    {
        private List<Medico> lista;
        int id_medico;
        public VistaMedico()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = true;
            PanelRegistro.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            limpiar();
        }

        private void limpiar()
        {
            tbxNombre.Clear();
            tbxApellido.Clear();
            tbxEspecialidad.Clear();
            tbxMatricula.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico Nuevo = new Medico();
            MedicoNegocio negocio = new MedicoNegocio();
            try
            {
                Nuevo.Nombre = tbxNombre.Text;
                Nuevo.Apellido = tbxApellido.Text;
                Nuevo.Matricula = tbxMatricula.Text;
                Nuevo.Especialidad = tbxEspecialidad.Text;
                negocio.Agregar(Nuevo);

                MessageBox.Show("Médico agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void VistaMedico_Load(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            DiseñoDgv(ref dgvMedico);
            CargarDatos();

        }

        private void CargarDatos()
        {
            try
            {
                MedicoNegocio negocioMedico = new MedicoNegocio();
                DisponibilidadNegocio negocioDisponibilidad = new DisponibilidadNegocio();

                List<Medico> listaMedicos = negocioMedico.listar();
                List<Disponibilidad> listaDisponibilidad = negocioDisponibilidad.listarDisponibilidad();

                var listaCombinada = listaMedicos.Select(m => new
                {
                    m.IdMedico,
                    m.Nombre,
                    m.Apellido,
                    m.Especialidad,
                    m.Matricula,
                    Disponibilidad = string.Join(", ", listaDisponibilidad
                        .Where(d => d.MedicoId == m.IdMedico)
                        .Select(d => d.DiaSemana))
                }).ToList();

                dgvMedico.DataSource = listaCombinada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static void DiseñoDgv(ref DataGridView dgv)
        {
            // General
            dgv.EnableHeadersVisualStyles = false; // Deshabilita el estilo visual predeterminado
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false; // Oculta los encabezados de fila
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección por fila completa
            dgv.MultiSelect = false; // Deshabilita la selección múltiple

            // Estilo de selección en encabezados
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent; // Sin cambio de color al seleccionar encabezado
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor; // Sin cambio de texto al seleccionar encabezado

            // Estilo de encabezados
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Fondo negro
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Letras blancas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Fuente en negrita
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación al centro
        }

        
        private void dgvMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMedico.Columns["EditarP"].Index)
            {
                ObtenerMedicoEditar(e.RowIndex);
                DiasMedico();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvMedico.Columns["Eliminar"].Index)
            {

                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este médico?",
                    "Confirmación de Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        int id_medico = Convert.ToInt32(dgvMedico.Rows[e.RowIndex].Cells["IdMedico"].Value);

                        DisponibilidadNegocio negocioDis = new DisponibilidadNegocio();
                        negocioDis.EliminarDisponibilidadMedico(id_medico);


                        MedicoNegocio negocio = new MedicoNegocio();
                        negocio.Eliminar(new Medico { IdMedico = id_medico });


                        MessageBox.Show("Médico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ObtenerMedicoEditar(int rowIndex)
        {
            try
            {
                id_medico = Convert.ToInt32(dgvMedico.Rows[rowIndex].Cells[2].Value);
                tbxNombre.Text = dgvMedico.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                tbxApellido.Text = dgvMedico.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                tbxEspecialidad.Text = dgvMedico.Rows[rowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                tbxMatricula.Text = dgvMedico.Rows[rowIndex].Cells[6].Value?.ToString() ?? string.Empty;

                PanelRegistro.Visible = true;
                PanelRegistro.Dock = DockStyle.Fill;
                btnGuardar.Visible = false;
                btnEditar.Visible = true;
                PanelRegistro.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del Medico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoNegocio negocio = new MedicoNegocio();
                Medico seleccionado =(Medico)dgvMedico.CurrentRow.DataBoundItem;
                DisponibilidadNegocio disponibilidad=new DisponibilidadNegocio();
                Disponibilidad Seleccionado=(Disponibilidad)dgvMedico.CurrentRow.DataBoundItem;
        
                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Apellido = tbxApellido.Text;
                seleccionado.Matricula = tbxMatricula.Text;
                seleccionado.Especialidad = tbxEspecialidad.Text;
                
                negocio.Modificar(seleccionado);

                MessageBox.Show("Medico modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Medico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el id_medico de la variable que ya tienes
                int Id_medico = id_medico;

                // Obtener los días seleccionados por el médico
                List<string> diasSeleccionados = ObtenerDiasDisponibles();

                // Validar si se seleccionó al menos un día
                if (diasSeleccionados.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un día de disponibilidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar los días seleccionados en la base de datos
                DisponibilidadNegocio disponibilidad = new DisponibilidadNegocio();
                foreach (var dia in diasSeleccionados)
                {
                    Disponibilidad nuevaDisponibilidad = new Disponibilidad
                    {
                        MedicoId = id_medico,  // Usar el id_medico que ya tienes
                        DiaSemana = dia        // Día de la semana correspondiente
                    };

                    disponibilidad.Agregar(nuevaDisponibilidad); // Llamar al método para insertar la disponibilidad
                }

                MessageBox.Show("Disponibilidad agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la disponibilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObtenerDiasDisponibles()
        {
            List<string> diasDisponibles = new List<string>();

            if (chLunes.Checked) diasDisponibles.Add("Lunes");
            if (chMartes.Checked) diasDisponibles.Add("Martes");
            if (ChMiercoles.Checked) diasDisponibles.Add("Miércoles");
            if (ChJueves.Checked) diasDisponibles.Add("Jueves");
            if (ChViernes.Checked) diasDisponibles.Add("Viernes");
            if (ChSabado.Checked) diasDisponibles.Add("Sábado");
            if (ChDomingo.Checked) diasDisponibles.Add("Domingo");

            return diasDisponibles;
        
        }

        
      
         private void DiasMedico()
         {
            DisponibilidadNegocio negocio = new DisponibilidadNegocio();
            int id = id_medico;
            List<string> diasDisponibles = negocio.ObtenerDiasPorMedico(id);


            string diasMensaje = "Días disponibles para el médico:\n" + string.Join(", ", diasDisponibles);
            MessageBox.Show(diasMensaje, "Debug: DiasMedico");


            foreach (string dia in diasDisponibles)
            {
                Console.WriteLine(dia);
            }

            // Marcar los CheckBox según los días disponibles
            if (diasDisponibles.Contains("Lunes")) chLunes.Checked = true;
            if (diasDisponibles.Contains("Martes")) chMartes.Checked = true;
            if (diasDisponibles.Contains("Miércoles")) ChMiercoles.Checked = true;
            if (diasDisponibles.Contains("Jueves")) ChJueves.Checked = true;
            if (diasDisponibles.Contains("Viernes")) ChViernes.Checked = true;
            if (diasDisponibles.Contains("Sábado")) ChSabado.Checked = true;
            if (diasDisponibles.Contains("Domingo")) ChDomingo.Checked = true;
          }


    }
}

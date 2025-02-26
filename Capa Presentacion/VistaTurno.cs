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
    public partial class VistaTurno : UserControl
    {
        private List<Turno> lista;
        private BindingSource bindingSource = new BindingSource();
        int id_Turno;
        public VistaTurno()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            try
            {
                TurnoNegocio turno = new TurnoNegocio();
                MedicoNegocio medico = new MedicoNegocio();
                PacienteNegocio paciente = new PacienteNegocio();

                List<Turno> turnos = turno.listar();
                List<Medico> ListaMedico = medico.listar();
                List<Capa_Dominio.Paciente> ListaPaciente = paciente.listar();

                    var listaCombinada = turnos.Select(t => new
                    {
                        t.IdTurno,
                        t.EstadoTurno,
                        t.Hora,

                        Fecha = t.Fecha.ToString("yyyy-MM-dd"),
                        Medico = ListaMedico.FirstOrDefault(m => m.IdMedico == t.MedicoId)?.Nombre + " " +
                    ListaMedico.FirstOrDefault(m => m.IdMedico == t.MedicoId)?.Apellido + " " +
                    ListaMedico.FirstOrDefault(m => m.IdMedico == t.MedicoId)?.Especialidad ?? "Sin médico",
                        Paciente = ListaPaciente.FirstOrDefault(p => p.IdPaciente == t.PacienteId)?.Nombre + " " +
                       ListaPaciente.FirstOrDefault(p => p.IdPaciente == t.PacienteId)?.Apellido ?? "Sin paciente",
                        MotivoConsulta = string.IsNullOrWhiteSpace(t.MotivoConsulta) ? "Sin motivo especificado" : t.MotivoConsulta,
                        Diagnostico = string.IsNullOrWhiteSpace(t.Diagnostico) ? "Diagnostico Pendiente" : t.Diagnostico,
                    }).ToList();


                    dgvTurno.DataSource = listaCombinada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void VistaTurno_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DiseñoDgv(ref dgvTurno);
            maskedTextBox1.Mask = "00:00";  // Formato HH:mm
            maskedTextBox1.ValidatingType = typeof(DateTime);
            ListarMedico();
            
           
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

        private void dgvTurno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTurno.Columns["EditarP"].Index)
            {
                ObtenerTurnoEditar(e.RowIndex);
                PanelTurno.Dock = DockStyle.Fill;

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvTurno.Columns["Eliminar"].Index)
            {
                // Mostrar un mensaje de confirmación
                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este paciente?",
                    "Confirmación de Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Verificar si el usuario seleccionó "Sí"
                if (confirmResult == DialogResult.Yes)
                {

                    try
                    {
                        TurnoNegocio turno = new TurnoNegocio();
                        DataGridViewRow row = dgvTurno.Rows[e.RowIndex];
                        int Turno = Convert.ToInt32(row.Cells["IdTurno"].Value);
                        turno.EliminarTurno(Turno);
                        // Mostrar mensaje de éxito
                        MessageBox.Show("Paciente eliminado correctamente." + Turno, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void ObtenerTurnoEditar(int rowIndex)
        {
            try
            {
                id_Turno = Convert.ToInt32(dgvTurno.Rows[rowIndex].Cells[2].Value);


                string fechaTexto = dgvTurno.Rows[rowIndex].Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(fechaTexto) && DateTime.TryParseExact(fechaTexto, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaTurno))
                {
                    dtpFecha.Value = fechaTurno;
                }
                else
                {
                    MessageBox.Show("El valor de la fecha no es válido o está vacío.", "Error");
                    dtpFecha.Value = DateTime.Now;
                }

                ObtenerMedico(rowIndex);

                cbxEstado.Text = dgvTurno.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                maskedTextBox1.Text = dgvTurno.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                tbxConsulta.Text = dgvTurno.Rows[rowIndex].Cells[8].Value?.ToString() ?? string.Empty;
                tbxDiagnostico.Text = dgvTurno.Rows[rowIndex].Cells[9].Value?.ToString() ?? string.Empty;
                PanelTurno.Visible = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void ObtenerMedico(int rowIndex)
        {
            MedicoNegocio medico = new MedicoNegocio();
            List<Medico> ListaMedico = medico.listar(); // Esto obtiene la lista de médicos.
            var medicosUnicos = ListaMedico
                .Select(m => new
                {
                    m.IdMedico,
                    NombreCompleto = $"{m.Nombre} {m.Apellido} {m.Especialidad}" // Crear el NombreCompleto
                })
                .ToList();

            // Asignar la lista de médicos al DataGridView (dgvMed)
            dgvMed.DataSource = medicosUnicos;

            // Obtener el valor del médico desde el DataGridView (dgvTurno)
            string medicoSeleccionado = dgvTurno.Rows[rowIndex].Cells["Medico"].Value?.ToString() ?? string.Empty;

            // Buscar el médico en la lista 'medicosUnicos' utilizando el campo NombreCompleto
            var medicoEncontrado = medicosUnicos
                .FirstOrDefault(m => m.NombreCompleto == medicoSeleccionado);  // Compara con NombreCompleto

            if (medicoEncontrado != null)
            {

                int index = -1;

                // Iterar sobre las filas del DataGridView (dgvMed) y comparar los valores de la celda de 'NombreCompleto'
                for (int i = 0; i < dgvMed.Rows.Count; i++)
                {
                    var cellValue = dgvMed.Rows[i].Cells["NombreCompleto"].Value?.ToString();
                    if (cellValue == medicoEncontrado.NombreCompleto)
                    {
                        index = i;
                        break;
                    }
                }

                // Depurar el valor de index
                if (index == -1)
                {
                    MessageBox.Show("No se encontró el índice del médico.");
                }


                dgvMed.DataSource = medicosUnicos;
                dgvMed.BeginInvoke(new Action(() =>
                {
                    // Buscar y seleccionar la fila como antes
                    if (index >= 0)
                    {
                        dgvMed.ClearSelection();
                        dgvMed.Rows[index].Selected = true;
                    }
                }));

            }
            else
            {
                MessageBox.Show("Médico no encontrado.");
            }
        }

       

        private void ListarMedico()
        {


            try
            {
                var listaMedicos = new MedicoNegocio().listar();
                bindingSource.DataSource = listaMedicos;
                dgvMed.DataSource = bindingSource;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno seleccionado = new Turno();

            try
            {

                seleccionado.IdTurno = id_Turno;


                if (TimeSpan.TryParse(maskedTextBox1.Text, out TimeSpan horaSeleccionada))
                {
                    seleccionado.Hora = horaSeleccionada;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una hora válida en formato HH:mm.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (DateTime.TryParse(dtpFecha.Text, out DateTime fechaSeleccionada))
                {
                    seleccionado.Fecha = fechaSeleccionada;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una fecha válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbxConsulta.Text))
                {
                    MessageBox.Show("El motivo de consulta no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                seleccionado.MotivoConsulta = tbxConsulta.Text.Trim();


                if (cbxEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un estado para el turno.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                seleccionado.EstadoTurno = cbxEstado.SelectedItem.ToString();

                if (dgvMed.SelectedRows.Count > 0)
                {

                    seleccionado.MedicoId = Convert.ToInt32(dgvMed.SelectedRows[0].Cells["IdMedico"].Value);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un médico de la lista.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Diagnostico = string.IsNullOrWhiteSpace(tbxDiagnostico.Text) ? "Diagnóstico pendiente" : tbxDiagnostico.Text.Trim();


                negocio.Modificar(seleccionado);

                MessageBox.Show("Turno actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                PanelTurno.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void DeshabilitarBotones(string rol)
        {
            if (rol == "Medico")
            {
                dgvMed.Enabled= false;
                maskedTextBox1.Enabled = false;
                tbxConsulta.Enabled = false;
                dtpFecha.Enabled = false;


                dgvTurno.Columns["Eliminar"].Visible = false;

                    

            }


        }





    }
}
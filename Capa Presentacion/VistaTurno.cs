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

        private void PreseleccionarMedicoEnPanel(int idMedico)
        {
            // Obtener el dgvMed desde el panelMedico
            DataGridView dgvMed = PanelTurno.Controls.OfType<DataGridView>().FirstOrDefault();

            if (dgvMed != null)
            {
                // Iterar sobre las filas de dgvMed para buscar al médico por su ID
                foreach (DataGridViewRow row in dgvMed.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Medico"].Value) == idMedico)
                    {
                        // Limpiar la selección previa
                        dgvMed.ClearSelection();

                        // Seleccionar la fila correspondiente al médico
                        row.Selected = true;

                        // Opcional: Hacer scroll hasta la fila seleccionada
                        dgvMed.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el DataGridView de Médicos en el panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                // Validar que se haya seleccionado un turno
                if (dgvTurno.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un turno para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que se haya seleccionado un médico
                if (dgvMed.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar el formato de la hora
                if (!TimeSpan.TryParse(maskedTextBox1.Text, out TimeSpan hora))
                {
                    MessageBox.Show("Ingrese una hora válida en el formato HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el motivo de consulta no esté vacío
                if (string.IsNullOrWhiteSpace(tbxConsulta.Text))
                {
                    MessageBox.Show("El motivo de consulta no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el turno seleccionado
                Turno turnoSeleccionado = (Turno)dgvTurno.CurrentRow.DataBoundItem;

                // Asignar valores desde los controles
                turnoSeleccionado.Medico = new Medico
                {
                    IdMedico = Convert.ToInt32(dgvMed.CurrentRow.Cells["IdMedico"].Value)
                };
                turnoSeleccionado.Fecha = dtpFecha.Value.Date;
                turnoSeleccionado.Hora = hora;
                turnoSeleccionado.MotivoConsulta = tbxConsulta.Text.Trim();
                turnoSeleccionado.EstadoTurno = cbxEstado.SelectedItem?.ToString();
                turnoSeleccionado.Diagnostico = tbxDiagnostico.Text.Trim();

                // Modificar el turno en la base de datos
                TurnoNegocio negocio = new TurnoNegocio();
                negocio.Modificar(turnoSeleccionado);

                MessageBox.Show("Turno modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
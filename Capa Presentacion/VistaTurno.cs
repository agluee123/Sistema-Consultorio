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
        int id_Turno;
        int id_Paciente;
        private List<Turno> lista;
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
                       ListaPaciente.FirstOrDefault(p => p.IdPaciente == t.PacienteId)?.Apellido ?? "Sin paciente"
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

            }

        }

        private void ObtenerTurnoEditar(int rowIndex)
        {
            try
            {
                id_Turno = Convert.ToInt32(dgvTurno.Rows[rowIndex].Cells[2].Value);
                dtpFecha.Text = dgvTurno.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                maskedTextBox1.Text = dgvTurno.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                tbxConsulta.Text = dgvTurno.Rows[rowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                cbxEstado.Text = dgvTurno.Rows[rowIndex].Cells[6].Value?.ToString() ?? string.Empty;
                tbxDiagnostico.Text = dgvTurno.Rows[rowIndex].Cells[7].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
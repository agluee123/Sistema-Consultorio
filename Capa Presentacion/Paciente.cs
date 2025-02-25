using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion
{
    public partial class Paciente : UserControl
    {
        private BindingSource bindingSource = new BindingSource();
        int id_Paciente;
        int id_Medico;

        private List<Capa_Dominio.Paciente> lista;
        private List<Medico> lista2;
        public Paciente()
        {
            InitializeComponent();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

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
            tbxDni.Clear();
            tbxCorreo.Clear();
            tbxTelefono.Clear();
            tbxDireccion.Clear();
            tbxCondicion.Clear();
            cbxGenero.SelectedIndex = -1;
        }

        private void PanelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Paciente_Load(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            PanelTurno.Visible = false;
            DiseñoDgv(ref DgvTurno);
            CargarDatos();
            maskedTextBox1.Mask = "00:00";  // Formato HH:mm
            maskedTextBox1.ValidatingType = typeof(DateTime);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capa_Dominio.Paciente NuevoPaciente = new Capa_Dominio.Paciente();
            PacienteNegocio negocio = new PacienteNegocio();
            try
            {

                List<string> errores = ValidarFormulario();

                if (errores.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", errores), "Errores en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NuevoPaciente.Nombre = tbxNombre.Text;
                NuevoPaciente.Apellido = tbxApellido.Text;
                NuevoPaciente.Dni = tbxDni.Text;
                NuevoPaciente.Correo = tbxCorreo.Text;
                NuevoPaciente.NumeroTel = tbxTelefono.Text;
                NuevoPaciente.Direccion = tbxDireccion.Text;
                NuevoPaciente.Genero = cbxGenero.SelectedItem?.ToString();
                NuevoPaciente.FechaNacimiento = dtpEdad.Value;
                NuevoPaciente.CondicionSalud = tbxCondicion.Text;
                negocio.Agregar(NuevoPaciente);

                MessageBox.Show("Paciente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show(
                   "¿Desea agregar otro paciente?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                 );

                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
                else
                {
                    limpiar();
                    PanelRegistro.Visible = false;
                    CargarDatos();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }


        // Método para validar correo electrónico
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //validar form

        private List<string> ValidarFormulario()
        {
            List<string> errores = new List<string>();

            if (string.IsNullOrWhiteSpace(tbxNombre.Text))
            {
                errores.Add("El nombre es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(tbxApellido.Text))
            {
                errores.Add("El apellido es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(tbxDni.Text) || !tbxDni.Text.All(char.IsDigit))
            {
                errores.Add("El DNI es obligatorio y debe contener solo números.");
            }
            if (string.IsNullOrWhiteSpace(tbxCorreo.Text) || !IsValidEmail(tbxCorreo.Text))
            {
                errores.Add("El correo electrónico es obligatorio y debe ser válido.");
            }
            if (string.IsNullOrWhiteSpace(tbxTelefono.Text) || !tbxTelefono.Text.All(char.IsDigit))
            {
                errores.Add("El teléfono es obligatorio y debe contener solo números.");
            }
            if (string.IsNullOrWhiteSpace(tbxDireccion.Text))
            {
                errores.Add("La dirección es obligatoria.");
            }
            if (cbxGenero.SelectedItem == null)
            {
                errores.Add("Debe seleccionar un género.");
            }
            if (dtpEdad.Value == DateTime.Today)
            {
                errores.Add("Debe seleccionar una fecha de nacimiento válida distinta a la actual.");
            }

            return errores;
        }



        private void CargarDatos()
        {

            try
            {
                lista = new PacienteNegocio().listar();
                DgvTurno.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvTurno.Columns["EditarP"].Index)
            {
                ObtenerPacientesEditar(e.RowIndex);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == DgvTurno.Columns["Eliminar"].Index)
            {

                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este paciente?",
                    "Confirmación de Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


                if (confirmResult == DialogResult.Yes)
                {
                    PacienteEliminar(e.RowIndex);

                    try
                    {
                        PacienteNegocio negocio = new PacienteNegocio();
                        Capa_Dominio.Paciente seleccionado = (Capa_Dominio.Paciente)DgvTurno.CurrentRow.DataBoundItem;

                        seleccionado.Nombre = tbxNombre.Text;
                        seleccionado.Apellido = tbxApellido.Text;
                        seleccionado.Dni = tbxDni.Text;
                        seleccionado.Correo = tbxCorreo.Text;
                        seleccionado.NumeroTel = tbxTelefono.Text;
                        seleccionado.Direccion = tbxDireccion.Text;
                        seleccionado.Genero = cbxGenero.SelectedItem?.ToString();
                        seleccionado.FechaNacimiento = dtpEdad.Value;
                        seleccionado.CondicionSalud = tbxCondicion.Text;

                        negocio.EliminarPaciente(seleccionado);


                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvTurno.Rows[e.RowIndex];
                id_Paciente = Convert.ToInt32(row.Cells["IdPaciente"].Value);
            }

        }

        private void ObtenerPacientesEditar(int rowIndex)
        {
            try
            {
                id_Paciente = Convert.ToInt32(DgvTurno.Rows[rowIndex].Cells[2].Value);
                tbxNombre.Text = DgvTurno.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                tbxApellido.Text = DgvTurno.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                tbxDni.Text = DgvTurno.Rows[rowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                tbxCorreo.Text = DgvTurno.Rows[rowIndex].Cells[6].Value?.ToString() ?? string.Empty;
                tbxTelefono.Text = DgvTurno.Rows[rowIndex].Cells[7].Value?.ToString() ?? string.Empty;
                tbxDireccion.Text = DgvTurno.Rows[rowIndex].Cells[8].Value?.ToString() ?? string.Empty;
                cbxGenero.SelectedItem = DgvTurno.Rows[rowIndex].Cells[9].Value?.ToString();
                dtpEdad.Value = Convert.ToDateTime(DgvTurno.Rows[rowIndex].Cells[10].Value);
                tbxCondicion.Text = DgvTurno.Rows[rowIndex].Cells[11].Value?.ToString() ?? string.Empty;
                PanelRegistro.Visible = true;
                PanelRegistro.Dock = DockStyle.Fill;
                btnGuardar.Visible = false;
                btnEditar.Visible = true;
                PanelRegistro.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PacienteEliminar(int rowIndex)
        {
            id_Paciente = Convert.ToInt32(DgvTurno.Rows[rowIndex].Cells[2].Value);
            tbxNombre.Text = DgvTurno.Rows[rowIndex].Cells[3].Value?.ToString() ?? string.Empty;
            tbxApellido.Text = DgvTurno.Rows[rowIndex].Cells[4].Value?.ToString() ?? string.Empty;
            tbxDni.Text = DgvTurno.Rows[rowIndex].Cells[5].Value?.ToString() ?? string.Empty;
            tbxCorreo.Text = DgvTurno.Rows[rowIndex].Cells[6].Value?.ToString() ?? string.Empty;
            tbxTelefono.Text = DgvTurno.Rows[rowIndex].Cells[7].Value?.ToString() ?? string.Empty;
            tbxDireccion.Text = DgvTurno.Rows[rowIndex].Cells[8].Value?.ToString() ?? string.Empty;
            cbxGenero.SelectedItem = DgvTurno.Rows[rowIndex].Cells[9].Value?.ToString();
            dtpEdad.Value = Convert.ToDateTime(DgvTurno.Rows[rowIndex].Cells[10].Value);
            tbxCondicion.Text = DgvTurno.Rows[rowIndex].Cells[11].Value?.ToString() ?? string.Empty;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteNegocio negocio = new PacienteNegocio();
                Capa_Dominio.Paciente seleccionado = (Capa_Dominio.Paciente)DgvTurno.CurrentRow.DataBoundItem;


                List<string> errores = ValidarFormulario();

                if (errores.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", errores), "Errores en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Apellido = tbxApellido.Text;
                seleccionado.Dni = tbxDni.Text;
                seleccionado.Correo = tbxCorreo.Text;
                seleccionado.NumeroTel = tbxTelefono.Text;
                seleccionado.Direccion = tbxDireccion.Text;
                seleccionado.Genero = cbxGenero.SelectedItem?.ToString();
                seleccionado.FechaNacimiento = dtpEdad.Value;
                seleccionado.CondicionSalud = tbxCondicion.Text;

                negocio.Modificar(seleccionado);

                MessageBox.Show("Paciente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PanelRegistro.Visible = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnTurno_Click(object sender, EventArgs e)
        {
            if (id_Paciente > 0)
            {
                PanelTurno.Visible = true;
                PanelTurno.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente primero.");
            }

        }

        private void PanelTurno_Paint(object sender, PaintEventArgs e)
        {
            ListarMedico();
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (DateTime.TryParseExact(maskedTextBox1.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime horaValida))
            {
                MessageBox.Show("Hora válida: " + horaValida.ToString("HH:mm"));
            }
            else
            {
                MessageBox.Show("Por favor ingresa una hora válida en el formato HH:mm.");
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


        private void dgvMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {

                    DataGridViewRow filaSeleccionada = dgvMed.Rows[e.RowIndex];


                    id_Medico = Convert.ToInt32(filaSeleccionada.Cells["IdMedico"].Value);

                    //MessageBox.Show("ID Médico seleccionado: " + idMedico.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar médico: " + ex.Message);
            }

        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            GuardarTurno();
        }

        private void GuardarTurno()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno seleccionado = new Turno();
            try
            {
                // Convertir el texto del MaskedTextBox a TimeSpan
                if (TimeSpan.TryParse(maskedTextBox1.Text, out TimeSpan horaSeleccionada))
                {
                    seleccionado.Hora = horaSeleccionada; // Asignar el TimeSpan al objeto Turno
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una hora válida en formato HH:mm.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Continuar con la asignación de otros valores...
                seleccionado.MedicoId = id_Medico;
                seleccionado.PacienteId = id_Paciente;

                if (!DateTime.TryParse(dtpFecha.Text, out DateTime fechaSeleccionada))
                {
                    MessageBox.Show("Por favor, ingresa una fecha válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                seleccionado.Fecha = fechaSeleccionada;

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
                string pendiente = "pendiente";
                seleccionado.Diagnostico = pendiente;

                // Verificar si el médico ya tiene un turno en la misma fecha y hora
                var turnoExistente = negocio.listar()
                    .FirstOrDefault(t => t.MedicoId == seleccionado.MedicoId &&
                                         t.Fecha.Date == seleccionado.Fecha.Date &&
                                         t.Hora == seleccionado.Hora);

                if (turnoExistente != null)
                {
                   
                    MessageBox.Show("La hora seleccionada ya está ocupada para este médico. Por favor, elige otra hora.", "Error de Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                negocio.Agregar(seleccionado);

               
                MessageBox.Show("El turno se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            if (id_Paciente > 0)
            {
         

                TurnoNegocio turno = new TurnoNegocio();
                MedicoNegocio medico = new MedicoNegocio();
                PacienteNegocio paciente = new PacienteNegocio();

                List<Turno> turnos = turno.listar();
                List<Medico> ListaMedico = medico.listar();
                List<Capa_Dominio.Paciente> ListaPaciente = paciente.listar();


                    var listaFiltrada = turnos
                   .Where(t => t.PacienteId == id_Paciente)
                   .Select(t => new
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


                if (listaFiltrada.Any()) 
                {
                    DgvTurno.DataSource = listaFiltrada;
                }
                else
                {
                    MessageBox.Show("El paciente no tiene historia clinica");
                    CargarDatos();
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente primero.");
            }
        }



       


  

    }

}


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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;  
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}

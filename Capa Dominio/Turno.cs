using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string MotivoConsulta { get; set; }
        public string EstadoTurno { get; set; } // Pendiente, Confirmado, Cancelado, Finalizado

        // Relación con Paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        // Relación con Medico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
}

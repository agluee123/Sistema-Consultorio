using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Disponibilidad
    {
        public int IdDisponibilidad { get; set; }
        public int MedicoId { get; set; }
        public string DiaSemana { get; set; } // Lunes, Martes, Miércoles, etc.

        // Relación con Medico
        public Medico Medico { get; set; }
    }
}

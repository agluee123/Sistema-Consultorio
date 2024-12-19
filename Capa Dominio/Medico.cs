using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }

        // Relación con Disponibilidad
        public string DiasDisponibles { get; set; }

        //// Relación con Turno
        //public ICollection<Turno> Turnos { get; set; }
    }
}

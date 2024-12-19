using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string NumeroTel { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; } // Masculino, Femenino, Otro
        public DateTime FechaNacimiento { get; set; }
        public string CondicionSalud { get; set; }

        // Relación con Turno
        //public ICollection<Turno> Turnos { get; set; }
    }
}

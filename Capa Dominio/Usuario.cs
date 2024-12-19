using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string UsuarioNombre { get; set; } // Para login
        public string Contraseña { get; set; } // Debe almacenarse cifrada
        public string Rol { get; set; } // Admin, Medico, Paciente, Otro
    }
}

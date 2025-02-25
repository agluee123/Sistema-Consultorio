using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class HistoriaCliniNegocio
    {
        private int SeleccionarHistoria(int id)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            int idTurno = -1;

            try
            {
                datos.setearConsulta("SELECT t.IdTurno FROM Turno t INNER JOIN Paciente p ON t.IdPaciente = p.IdPaciente WHERE p.IdPaciente = @IdPaciente");
                datos.setearParametro("@IdPaciente", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idTurno = Convert.ToInt32(datos.Lector["IdTurno"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return idTurno;

        }
    }
}

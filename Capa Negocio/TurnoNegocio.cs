using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class TurnoNegocio
    {
        public void Agregar(Turno nuevo)
        {

            Acceso_a_datos datos = new Acceso_a_datos();
            datos.setearConsulta("INSERT INTO Turno (Fecha,Hora, MotivoConsulta,EstadoTurno,MedicoId,PacienteId) " +
                     "VALUES (@Fecha, @Hora, @MotivoConsulta, @EstadoTurno, @MedicoId, @PacienteId)");

            datos.setearParametro("@Fecha", nuevo.Fecha);
            datos.setearParametro("@Hora", nuevo.Hora);
            datos.setearParametro("@MotivoConsulta", nuevo.MotivoConsulta);
            datos.setearParametro("@EstadoTurno", nuevo.EstadoTurno);
            datos.setearParametro("@MedicoId", nuevo.MedicoId);
            datos.setearParametro("@PacienteId", nuevo.PacienteId);


            datos.ejecutarAccion();
            datos.cerrarConexion();


        }

    }
}

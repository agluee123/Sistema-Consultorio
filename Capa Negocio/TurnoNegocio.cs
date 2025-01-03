using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<Turno> listar()
        {
            List<Turno> lista = new List<Turno>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ConsultorioDB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Turno ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Turno aux = new Turno();
                    aux.IdTurno = (int)lector["IdTurno"];
                    aux.Fecha = (DateTime)lector["Fecha"];
                    aux.Hora = (TimeSpan)lector["Hora"];
                    aux.MotivoConsulta = (string)lector["MotivoConsulta"];
                    aux.EstadoTurno = (string)lector["EstadoTurno"];
                    aux.MedicoId = (int)lector["MedicoId"];
                    aux.PacienteId = (int)lector["PacienteId"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

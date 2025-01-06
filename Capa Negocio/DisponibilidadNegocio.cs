using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class DisponibilidadNegocio
    {
        public void Agregar(Disponibilidad nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("INSERT INTO Disponibilidad (MedicoId, DiaSemana) " +
                                     "VALUES (@MedicoId, @DiaSemana)");

                datos.setearParametro("@MedicoId", nuevo.MedicoId);  
                datos.setearParametro("@DiaSemana", nuevo.DiaSemana); 

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la disponibilidad: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Disponibilidad> listarDisponibilidad()
        {
            List<Disponibilidad> lista = new List<Disponibilidad>();
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.setearConsulta("SELECT * FROM Disponibilidad");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disponibilidad disp = new Disponibilidad
                    {
                        MedicoId = (int)datos.Lector["MedicoId"],
                        DiaSemana = datos.Lector["DiaSemana"].ToString()
                    };
                    lista.Add(disp);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar disponibilidad: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void EliminarDisponibilidadMedico(int MedicoId)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("DELETE FROM Disponibilidad WHERE MedicoId = @MedicoId");
                datos.setearParametro("@MedicoId", MedicoId);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los artículos del pedido: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Disponibilidad modificar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("UPDATE Disponibilidad SET MedicoId = @MedicoId, DiaSemana = @DiaSemana");

                datos.setearParametro("@MedicoId", modificar.MedicoId);
                datos.setearParametro("@DiaSemana", modificar.DiaSemana);
                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<string> ObtenerDiasPorMedico(int id_medico)
        {
            List<string> dias = new List<string>();
            using (SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS; database=ConsultorioDB; integrated security=true"))
            {
                int Id_medico = id_medico;
                //Message.Show($"Obteniendo días para IdMedico: {Id_medico}", "Debug: ObtenerDiasPorMedico");



                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DiaSemana FROM Disponibilidad WHERE MedicoId = @MedicoId", con);
                cmd.Parameters.AddWithValue("@MedicoId", Id_medico);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string dia = reader["DiaSemana"].ToString();
                    dias.Add(dia);


                    //MessageBox.Show($"Día obtenido: {dia}", "Debug: Días");

                }
            }
            return dias;
        }

    }
}

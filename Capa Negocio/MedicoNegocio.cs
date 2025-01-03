using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class MedicoNegocio
    {
        public void Agregar(Medico nuevo)
        {

            Acceso_a_datos datos = new Acceso_a_datos();
            datos.setearConsulta("INSERT INTO Medico (Nombre, Apellido, Especialidad, Matricula) " +
                     "VALUES (@Nombre, @Apellido, @Especialidad,@Matricula)");

            datos.setearParametro("@Nombre", nuevo.Nombre);
            datos.setearParametro("@Apellido", nuevo.Apellido);
            datos.setearParametro("@Especialidad", nuevo.Especialidad);
            datos.setearParametro("@Matricula", nuevo.Matricula);


            datos.ejecutarAccion();
            datos.cerrarConexion();


        }

        public List<Medico> listar()
        {
            List<Medico> lista = new List<Medico>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ConsultorioDB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Medico ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Medico aux = new Medico();
                    aux.IdMedico = (int)lector["idMedico"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.Especialidad = (string)lector["Especialidad"];
                    aux.Matricula = (string)lector["Matricula"];

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

        public void Modificar(Medico modificar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("UPDATE Medico SET Nombre = @Nombre, Apellido = @Apellido, Especialidad = @Especialidad, Matricula = @Matricula WHERE IdMedico = @IdMedico");

                datos.setearParametro("@IdMedico", modificar.IdMedico);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@Apellido", modificar.Apellido);
                datos.setearParametro("@Especialidad", modificar.Especialidad);
                datos.setearParametro("@Matricula", modificar.Matricula);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Eliminar(Medico eliminar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {

                datos.setearConsulta("DELETE FROM Medico WHERE IdMedico = @Id");
                datos.setearParametro("@Id", eliminar.IdMedico);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el artículo: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}

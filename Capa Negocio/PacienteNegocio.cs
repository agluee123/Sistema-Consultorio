using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class PacienteNegocio
    {
        public void Agregar(Paciente nuevo)
        {

            Acceso_a_datos datos = new Acceso_a_datos();
            datos.setearConsulta("INSERT INTO Paciente (Nombre, Apellido, Dni, Correo, NumeroTel, Direccion, Genero, FechaNacimiento, CondicionSalud) " +
                     "VALUES (@Nombre, @Apellido, @Dni, @Correo, @NumeroTel, @Direccion, @Genero, @FechaNacimiento, @CondicionSalud)");

            datos.setearParametro("@Nombre", nuevo.Nombre);
            datos.setearParametro("@Apellido", nuevo.Apellido);
            datos.setearParametro("@Dni", nuevo.Dni);
            datos.setearParametro("@Correo", nuevo.Correo);
            datos.setearParametro("@NumeroTel", nuevo.NumeroTel);
            datos.setearParametro("@Direccion", nuevo.Direccion);
            datos.setearParametro("@Genero", nuevo.Genero);
            datos.setearParametro("@FechaNacimiento", nuevo.FechaNacimiento);
            datos.setearParametro("@CondicionSalud", nuevo.CondicionSalud);

            datos.ejecutarAccion();
            datos.cerrarConexion();


        }

        public List<Paciente> listar()
        {
            List<Paciente> lista = new List<Paciente>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ConsultorioDB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Paciente ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.IdPaciente = (int)lector["idPaciente"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.Dni = (string)lector["Dni"];
                    aux.Correo = (string)lector["Correo"];
                    aux.NumeroTel = (string)lector["NumeroTel"];
                    aux.Direccion = (string)lector["Direccion"];
                    aux.Genero = (string)lector["Genero"];
                    aux.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                    aux.CondicionSalud = (string)lector["CondicionSalud"];

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

        public void Modificar(Paciente modificar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("UPDATE Paciente SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, Correo = @Correo, NumeroTel = @NumeroTel, Direccion = @Direccion, Genero = @Genero, FechaNacimiento = @FechaNacimiento, CondicionSalud = @CondicionSalud WHERE IdPaciente = @IdPaciente");

                datos.setearParametro("@IdPaciente", modificar.IdPaciente);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@Apellido", modificar.Apellido);
                datos.setearParametro("@Dni", modificar.Dni);
                datos.setearParametro("@Correo", modificar.Correo);
                datos.setearParametro("@NumeroTel", modificar.NumeroTel);
                datos.setearParametro("@Direccion", modificar.Direccion);
                datos.setearParametro("@Genero", modificar.Genero);
                datos.setearParametro("@FechaNacimiento", modificar.FechaNacimiento);
                datos.setearParametro("@CondicionSalud", modificar.CondicionSalud);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarPaciente(Paciente eliminar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {

                datos.setearConsulta("DELETE FROM Paciente WHERE IdPaciente = @Id");
                datos.setearParametro("@Id", eliminar.IdPaciente);
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

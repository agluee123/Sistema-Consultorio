using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class UsuarioNegocio
    {
        public void Agregar(Usuario nuevo)
        {

            Acceso_a_datos datos = new Acceso_a_datos();

            datos.setearConsulta("INSERT INTO Usuario (Nombre, Dni, Usuario,Contraseña, Rol) " +
                     "VALUES (@Nombre, @Dni, @Usuario, @Contraseña, @Rol)");

            datos.setearParametro("@Nombre", nuevo.Nombre);
            datos.setearParametro("@Dni", nuevo.Dni);
            datos.setearParametro("@Usuario", nuevo.UsuarioNombre);
            datos.setearParametro("@Contraseña", nuevo.Contraseña);
            datos.setearParametro("@Rol", nuevo.Rol);
            datos.ejecutarAccion();
            datos.cerrarConexion();


        }

        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ConsultorioDB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Usuario ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = (int)lector["idUsuario"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Dni = (string)lector["Dni"];
                    aux.UsuarioNombre = (string)lector["Usuario"];
                    aux.Contraseña = (string)lector["Contraseña"];
                    aux.Rol = (string)lector["Rol"];
                
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

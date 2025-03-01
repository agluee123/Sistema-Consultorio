﻿using Capa_Dominio;
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
        private int intentos = 0;
        private const int MaxIntentos = 3;
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

        public void Modificar(Usuario modificar)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("UPDATE Usuario SET Nombre = @Nombre, Dni = @Dni, Usuario = @Usuario, Contraseña = @Contraseña, Rol = @Rol WHERE IdUsuario = @IdUsuario");

                datos.setearParametro("@IdUsuario", modificar.IdUsuario);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Dni", modificar.Dni);
                datos.setearParametro("@Usuario", modificar.UsuarioNombre);
                datos.setearParametro("@Contraseña", modificar.Contraseña);
                datos.setearParametro("@Rol", modificar.Rol);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarUsuario(int id_usuario)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.setearConsulta("DELETE FROM Usuario WHERE IdUsuario = @Id");
                datos.setearParametro("@Id", id_usuario);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Usuario: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }

        }


        public string AutenticarUsuario(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                return "Los campos no pueden estar vacíos";

            string rol = ValidarUsuario(usuario, contraseña);

            if (rol != null)
            {
                intentos = 0; // Reiniciar intentos si es correcto
                return rol;
            }
            else
            {
                intentos++;
                if (intentos >= MaxIntentos)
                    return "Cuenta bloqueada por múltiples intentos fallidos";

                return "Usuario o contraseña incorrectos";
            }
        }

        private string ValidarUsuario(string usuario, string contraseña)
        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.setearConsulta("SELECT Rol FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña");
                datos.setearParametro("@Usuario", usuario);
                datos.setearParametro("@Contraseña", contraseña);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    return datos.Lector["Rol"].ToString();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }




        }

    }
}

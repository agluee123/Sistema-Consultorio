using Capa_Dominio;
using System;
using System.Collections.Generic;
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

    }
}

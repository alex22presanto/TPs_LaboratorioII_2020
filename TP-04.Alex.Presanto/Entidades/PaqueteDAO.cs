using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;


        static PaqueteDAO()
        {
            try
            {
                conexion = new SqlConnection(@"Data Source = DESKTOP-V3IDIKT\SQLEXPRESS; Database = correo-sp-2017; Trusted_Connection = true;");
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Insertar(Paquete p)
        {
            string insert;

            try
            {
                insert = string.Format("INSERT INTO Paquetes VALUES ('{0}','{1}','{2}');", p.TrackingID, p.DireccionEntraega,"Alex Presanto");
                comando.CommandText = insert;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}

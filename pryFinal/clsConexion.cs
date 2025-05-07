using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinal
{
    public class clsConexion
    {

        private readonly string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Contactos.mdb";
        private OleDbConnection conexion;

        public clsConexion() 
        {
            string rutaBase = Application.StartupPath;
            cadenaConexion = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={rutaBase}\\Contactos.mdb";
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void Abrir()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                Abrir();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Cerrar();
            }
            return tabla;
        }

        public void EjecutarComando(string comando, Dictionary<string, object> parametros)
        {
            try
            {
                Abrir();
                using (OleDbCommand cmd = new OleDbCommand(comando, conexion))
                {
                    foreach (var param in parametros)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando: " + ex.Message);
            }
            finally
            {
                Cerrar();
            }
        }

    }
}

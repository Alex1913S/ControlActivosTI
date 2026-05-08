using System;
using System.Data;
using Microsoft.Data.SqlClient; // Esta es la que contiene SqlCommand
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionSql
    {
        protected readonly string _connectionString;

        // Objetos para persistencia de datos (DataSet)
        public DataSet Ds = new DataSet();
        public DataSet DsDM = new DataSet();
        private SqlDataAdapter Da;
        private SqlDataAdapter DaDM;
        private SqlCommandBuilder Cmb;
        private SqlCommandBuilder CmbDM;

        public ConexionSql()
        {
            _connectionString = @"Data Source=TI-ALEXANDER;Initial Catalog=GSSGSI1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        }

        // Método para obtener la conexión lista para usar
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public static class VariablesGlobales
        {
            public static int xEstIni = 0;
            public static string xNomU = "";
            public static string xTipoU = "";
            public static byte[] xFoto; // (byte[])fila["Foto"];
        }

        public void ConsultaDatos(string sql, string Tabla)
        {
            Ds.Tables.Clear();
            try
            {
                Da = new SqlDataAdapter(sql, _connectionString);
                Cmb = new SqlCommandBuilder(Da);
                Da.Fill(Ds, Tabla);
            }
            catch (SqlException ex)
            {
                // registrar 'sql' y ex.Message antes de relanzar
                throw new Exception($"Error al ejecutar SQL: {sql}. Mensaje: {ex.Message}", ex);
            }
        }

        public void ConsultaDatosDM(string sql, string Tabla)
        {
            DsDM.Tables.Clear();
            DaDM = new SqlDataAdapter(sql, _connectionString);
            CmbDM = new SqlCommandBuilder(DaDM);
            DaDM.Fill(DsDM, Tabla);
        }

        public bool Insertar(string sql)
        {
            using (var Conn = GetConnection())
            {
                Conn.Open();
                SqlCommand Comando = new SqlCommand(sql, Conn);
                int i = Comando.ExecuteNonQuery();
                return i > 0;
            } // El bloque using cierra la conexión automáticamente
        }

        public bool ConsultaItem(string tabla, string condicion)
        {
            using (var Conn = GetConnection())
            {
                Conn.Open();
                string query = $"Select Count(*) From {tabla} Where {condicion}";
                SqlCommand Comando = new SqlCommand(query, Conn);
                int i = Convert.ToInt32(Comando.ExecuteScalar());
                return i > 0;
            }
        }

        public bool ConsultaLike(string tabla, string condicion)
        {
            using (var Conn = GetConnection())
            {
                Conn.Open();
                string query = $"Select Count(*) From {tabla} Where {condicion}";
                SqlCommand Comando = new SqlCommand(query, Conn);
                // Usamos Count(*) porque ExecuteScalar devuelve un número, 
                // intentar convertir un "Nombre" (string) a Int32 daría error.
                int i = Convert.ToInt32(Comando.ExecuteScalar());
                return i > 0;
            }
        }

        public bool Eliminar(string tabla, string condicion)
        {
            using (var Conn = GetConnection())
            {
                Conn.Open();
                string query = $"Delete From {tabla} Where {condicion}";
                SqlCommand Comando = new SqlCommand(query, Conn);
                int i = Comando.ExecuteNonQuery();
                return i > 0;
            }
        }

        public bool Actualizar(string tabla, string campos, string condicion)
        {
            using (var Conn = GetConnection())
            {
                Conn.Open();
                string query = $"Update {tabla} set {campos} Where {condicion}";
                SqlCommand Comando = new SqlCommand(query, Conn);
                int i = Comando.ExecuteNonQuery();
                return i > 0;
            }
        }

        public bool Buscar(string tabla, string condicion)
        {
            // Nota: Corregido para que cuente registros en lugar de intentar convertir texto a número
            using (var Conn = GetConnection())
            {
                Conn.Open();
                string query = $"Select Count(*) From {tabla} Where {condicion}";
                SqlCommand Comando = new SqlCommand(query, Conn);
                int i = Convert.ToInt32(Comando.ExecuteScalar());
                return i > 0;
            }
        }
    }
}

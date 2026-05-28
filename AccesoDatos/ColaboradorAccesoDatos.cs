using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace AccesoDatos
{
    public class ColaboradorAccesoDatos: ConexionSql
    {
        public bool InsertarColaborador(
            string documentoIdentidad, string nombres, string apellidos,
            string correoCorporativo, int departamentoId, int ubicacionId,
            DateTime fechaIngreso, string estado, int perfilId,
            string usuarioApp, string passwordHash, byte[] foto, string cargo)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Core.Colaboradores 
                 (DocumentoIdentidad, Nombres, Apellidos, CorreoCorporativo, 
                  DepartamentoID, UbicacionID, FechaIngreso, Estado, 
                  PerfilID, UsuarioApp, PasswordHash, Foto, Cargo)
                 VALUES 
                 (@cedula, @nombres, @apellidos, @correo, 
                  @deptoId, @ubiId, @fechaIngreso, @estado, 
                  @perfilId, @usuario, HASHBYTES('SHA2_256', @pass), @foto, @cargo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = documentoIdentidad;
                    cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = nombres;
                    cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = apellidos;
                    cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correoCorporativo;
                    cmd.Parameters.Add("@deptoId", SqlDbType.Int).Value = departamentoId;
                    cmd.Parameters.Add("@ubiId", SqlDbType.Int).Value = ubicacionId;
                    cmd.Parameters.Add("@fechaIngreso", SqlDbType.DateTime).Value = fechaIngreso;
                    cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = (estado == "Activo");
                    cmd.Parameters.Add("@perfilId", SqlDbType.Int).Value = perfilId;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioApp;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordHash;
                    cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo;

                    if (foto != null)
                        cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = foto;
                    else
                        cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = DBNull.Value; 

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable ObtenerDepartamentos()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                // VERIFICA: Si en tu BD no se llama 'Nombre', cámbialo por el nombre real (ej. NombreDepartamento)
                string query = "SELECT DepartamentoID, Nombre FROM Core.Departamentos ORDER BY Nombre ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerUbicaciones()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                // AQUÍ ESTABA EL ERROR: Cambiamos 'Nombre' por 'NombreNomenclatura' tanto en el SELECT como en el ORDER BY
                string query = "SELECT UbicacionID, NombreNomenclatura FROM Core.Ubicaciones ORDER BY NombreNomenclatura ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerPerfiles()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                // Según tu archivo UsuarioAccesoDatos.cs, la columna se llama 'NombrePerfil'
                string query = "SELECT PerfilID, NombrePerfil FROM Seguridad.Perfiles ORDER BY NombrePerfil ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}

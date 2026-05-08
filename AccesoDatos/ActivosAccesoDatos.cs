using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AccesoDatos
{
    public class ActivosAccesoDatos : ConexionSql
    {
        public bool InsertarActivo(
            // ActivosBase
            int categoriaId, int ubicacionId,
            string marca, string modelo,
            string numeroSerie, int? proveedorId,
            DateTime? fechaAdquis, decimal? costo,
            string estadoOperativo,

            // EspecificacionesHardware
            string procesador, string memoriaRAM,
            string almac1, string almac2,
            string tarjetaGrafica, string sistemaOperativo,
            string mac, string ip,
            string resolucion)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // ✅ GUID generado en C#
                        Guid activoId = Guid.NewGuid();

                        // 1️⃣ INSERT ActivosBase
                        string sqlBase = @"
                            INSERT INTO ITAM.ActivosBase
                                (ActivoID, CategoriaID, UbicacionID,
                                 Marca, Modelo, NumeroSerie, ProveedorID,
                                 FechaAdquisicion, Costo, EstadoOperativo)
                            VALUES
                                (@ActivoID, @CategoriaID, @UbicacionID,
                                 @Marca, @Modelo, @NumeroSerie, @ProveedorID,
                                 @FechaAdquisicion, @Costo, @EstadoOperativo)";

                        var cmdBase = new SqlCommand(sqlBase, conn, transaction);
                        cmdBase.Parameters.Add("@ActivoID", SqlDbType.UniqueIdentifier).Value = activoId;
                        cmdBase.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = categoriaId;
                        cmdBase.Parameters.Add("@UbicacionID", SqlDbType.Int).Value = ubicacionId;
                        cmdBase.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = marca ?? (object)DBNull.Value;
                        cmdBase.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = modelo ?? (object)DBNull.Value;
                        cmdBase.Parameters.Add("@NumeroSerie", SqlDbType.VarChar).Value = numeroSerie ?? (object)DBNull.Value;
                        cmdBase.Parameters.Add("@ProveedorID", SqlDbType.Int).Value = proveedorId.HasValue ? proveedorId.Value : (object)DBNull.Value;
                        cmdBase.Parameters.Add("@FechaAdquisicion", SqlDbType.Date).Value = fechaAdquis.HasValue ? fechaAdquis.Value : (object)DBNull.Value;
                        cmdBase.Parameters.Add("@Costo", SqlDbType.Decimal).Value = costo.HasValue ? costo.Value : (object)DBNull.Value;
                        cmdBase.Parameters.Add("@EstadoOperativo", SqlDbType.VarChar).Value = estadoOperativo ?? (object)DBNull.Value;

                        cmdBase.ExecuteNonQuery();

                        // 2️⃣ INSERT EspecificacionesHardware con el mismo GUID
                        string sqlEspec = @"
                            INSERT INTO ITAM.EspecificacionesHardware
                                (ActivoID, Procesador, MemoriaRAM,
                                 Almacenamiento1, Almacenamiento2,
                                 TarjetaGrafica, SistemaOperativo,
                                 DireccionMAC, DireccionIP_Estatica,
                                 ResolucionPantalla)
                            VALUES
                                (@ActivoID, @Procesador, @MemoriaRAM,
                                 @Almacenamiento1, @Almacenamiento2,
                                 @TarjetaGrafica, @SistemaOperativo,
                                 @MAC, @IP, @Resolucion)";

                        var cmdEspec = new SqlCommand(sqlEspec, conn, transaction);
                        cmdEspec.Parameters.Add("@ActivoID", SqlDbType.UniqueIdentifier).Value = activoId;
                        cmdEspec.Parameters.Add("@Procesador", SqlDbType.NVarChar).Value = procesador ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@MemoriaRAM", SqlDbType.VarChar).Value = memoriaRAM ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@Almacenamiento1", SqlDbType.NVarChar).Value = almac1 ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@Almacenamiento2", SqlDbType.NVarChar).Value = almac2 ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@TarjetaGrafica", SqlDbType.NVarChar).Value = tarjetaGrafica ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@SistemaOperativo", SqlDbType.NVarChar).Value = sistemaOperativo ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@MAC", SqlDbType.VarChar).Value = mac ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@IP", SqlDbType.VarChar).Value = ip ?? (object)DBNull.Value;
                        cmdEspec.Parameters.Add("@Resolucion", SqlDbType.VarChar).Value = resolucion ?? (object)DBNull.Value;

                        cmdEspec.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

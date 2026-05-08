using AccesoDatos;

namespace Dominio
{
    public class ResultadoLogin
    {
        public bool Exitoso { get; set; }
        public bool Bloqueado { get; set; }
        public int Intentos { get; set; }
        public string Mensaje { get; set; } = "";

        // Datos del usuario
        public string Nombres { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Departamento { get; set; } = "";
        public string Rol { get; set; } = string.Empty;
        public string Cargo { get; set; } = ""; 
        public byte[] Foto { get; set; }
    }

    public class ResultadoActivo
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; } = "";

    }



    public class UsuarioDominio
    {
        private readonly UsuarioAccesoDatos _accesoDatos = new UsuarioAccesoDatos();
        private int _intentosFallidos = 0;
        private const int MaxIntentos = 3;

        public ResultadoLogin Login(string correo, string passwordHash)
        {
            var resultado = new ResultadoLogin();

            try
            {
                if (_intentosFallidos >= MaxIntentos)
                {
                    resultado.Exitoso = false;
                    resultado.Bloqueado = true;
                    resultado.Intentos = _intentosFallidos;
                    resultado.Mensaje = "Usuario bloqueado. Consulte al administrador.";
                    return resultado;
                }

                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(passwordHash))
                {
                    resultado.Exitoso = false;
                    resultado.Mensaje = "El correo y la contraseña son obligatorios.";
                    resultado.Intentos = _intentosFallidos;
                    return resultado;
                }

                bool credencialesValidas = _accesoDatos.ValidarCredenciales(correo, passwordHash);

                if (credencialesValidas)
                {
                   
                    var datos = _accesoDatos.ObtenerDatosUsuario(correo);

                    resultado.Exitoso = true;
                    resultado.Bloqueado = false;
                    resultado.Intentos = 0;
                    resultado.Mensaje = "Inicio de sesión exitoso.";
                    resultado.Nombres = datos.Nombres;
                    resultado.Apellidos = datos.Apellidos;
                    resultado.Departamento = datos.Departamento;
                    resultado.Rol = datos.Rol;
                    resultado.Cargo = datos.Cargo;
                    resultado.Foto = datos.Foto;    
                    _intentosFallidos = 0;
                }
                else
                {
                    _intentosFallidos++;
                    resultado.Exitoso = false;
                    resultado.Bloqueado = _intentosFallidos >= MaxIntentos;
                    resultado.Intentos = _intentosFallidos;
                    resultado.Mensaje = resultado.Bloqueado
                        ? "Superó el número de intentos. Consulte al administrador."
                        : $"Credenciales incorrectas. Intentos restantes: {MaxIntentos - _intentosFallidos}";
                }
            }
            catch (Exception ex)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = $"ERROR: {ex.Message}";
            }

            return resultado;
        }

        public class ActivosDominio
        {
            private readonly ActivosAccesoDatos _datos = new ActivosAccesoDatos();

            public ResultadoActivo CrearActivo(
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
                var resultado = new ResultadoActivo();

                try
                {
                    // ── Validaciones ─────────────────────────────────────
                    if (categoriaId <= 0)
                    {
                        resultado.Exitoso = false;
                        resultado.Mensaje = "Debe seleccionar una categoría.";
                        return resultado;
                    }

                    if (ubicacionId <= 0)
                    {
                        resultado.Exitoso = false;
                        resultado.Mensaje = "Debe seleccionar una ubicación.";
                        return resultado;
                    }

                    // ── Insertar en las dos tablas ────────────────────────
                    bool ok = _datos.InsertarActivo(
                        categoriaId, ubicacionId,
                        marca, modelo,
                        numeroSerie, proveedorId,
                        fechaAdquis, costo,
                        estadoOperativo,
                        procesador, memoriaRAM,
                        almac1, almac2,
                        tarjetaGrafica, sistemaOperativo,
                        mac, ip,
                        resolucion
                    );

                    resultado.Exitoso = ok;
                    resultado.Mensaje = ok
                        ? "Activo registrado correctamente."
                        : "No se pudo registrar el activo.";
                }
                catch (Exception ex)
                {
                    resultado.Exitoso = false;
                    resultado.Mensaje = $"ERROR: {ex.Message}";
                }

                return resultado;
            }
        }
    }


}
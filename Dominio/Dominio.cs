using AccesoDatos;

namespace Dominio
{
    public class ResultadoLogin
    {
        public bool Exitoso { get; set; }
        public bool Bloqueado { get; set; }
        public int Intentos { get; set; }
        public string Mensaje { get; set; }
    }

}
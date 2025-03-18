using System.Reflection.Metadata;

namespace Entidades
{
    public class Persona
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string ServicioMedico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Notificaciones { get; set; }
        public byte[] FotoPerfil { get; set; }
        public string Sexo { get; set; }

    }
}

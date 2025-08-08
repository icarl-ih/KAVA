using System.ComponentModel.DataAnnotations;

namespace SyncfusionBlazorApp1.Models
{
    public class Usuarios
    {
        public int Id_Empleado { get; set; }
        [Required(ErrorMessage = "Obligatorio")] public string A_Paterno { get; set; }
        [Required(ErrorMessage = "Obligatorio")] public string A_Materno { get; set; }
        [Required(ErrorMessage = "Obligatorio")] public string Nombres { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")] public string Email { get; set; }
        public long Celular { get; set; }
        public string Licenciatura { get; set; }
        public int Cedula { get; set; }
        public DateTime FechaNac { get; set; }
        public string Posgrados { get; set; }
        public int Id_Cargo { get; set; }

        public string NombreCompleto => $"{A_Paterno} {A_Materno} {Nombres}";

    }
}

using System.ComponentModel.DataAnnotations;

namespace SyncfusionBlazorApp1.lib
{
    public class Usuario
    {
        [Required(ErrorMessage = "Apellido paterno es obligatorio")]
        public string A_Paterno { get; set; }

        [Required(ErrorMessage = "Apellido materno es obligatorio")]
        public string A_Materno { get; set; }

        [Required(ErrorMessage = "Nombres son obligatorios")]
        public string Nombres { get; set; }

        [Required, EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required]
        public long Celular { get; set; }

        public string Licenciatura { get; set; }
        public int Cedula { get; set; }

        [Required]
        public DateTime FechaNac { get; set; } = DateTime.Today;

        public string Posgrados { get; set; }
        public int Id_Cargo { get; set; }

        public int Id_Empleado { get; set; }

        public string NombreCompleto => $"{A_Paterno} {A_Materno} {Nombres}";
    }
}
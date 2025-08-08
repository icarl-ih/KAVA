using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SyncfusionBlazorApp1.Data
{
    public class EmployeeDetails
    {
        public EmployeeDetails()
        {

        }

        [Editable(false)]
        [Display(Name = "Employee ID")]
        public int? EmployeeId { get; set; }

        [Required(ErrorMessage = "Obligatorio")][Display(Name = "Date Of Birth")] public string A_Paterno { get; set; }
        [Required(ErrorMessage = "Obligatorio")] public string A_Materno { get; set; }
        [Required(ErrorMessage = "Obligatorio")] public string Nombres { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")] public string Email { get; set; }
        public long Celular { get; set; }
        public string Licenciatura { get; set; }
        public int Cedula { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required")]
        [Display(Name = "Date Of Birth")]
        public DateOnly? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Please choose the country")]
        [Display(Name = "Country")]
        public string Country { get; set; }
        public int Id_Empleado { get; set; }
        
        public DateTime FechaNac { get; set; }
        public string Posgrados { get; set; }
        public int Id_Cargo { get; set; }

        public string NombreCompleto => $"{A_Paterno} {A_Materno} {Nombres}";
    }
}

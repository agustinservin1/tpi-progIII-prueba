using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Request
{
    public class DoctorCreateRequest
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
        
        [Required]
        [EnumDataType(typeof(Specialty))]
        public Specialty Specialty { get; set; }
        public int LicenseNumber { get; set; }
    }
}

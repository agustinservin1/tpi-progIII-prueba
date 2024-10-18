using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Patient : User
    {
        [MaxLength(50)]
        public string MedicalInsurance { get; set; } = string.Empty;
        public ICollection<Appointment> Appoitments { get; set; } = new List<Appointment>();
        public Address Address { get; set; }    
        public Patient()
        {
            UserRole = UserRole.Patient;

        }
    }
}

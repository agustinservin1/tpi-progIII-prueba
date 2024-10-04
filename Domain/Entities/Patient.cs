using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient : User
    {
        [MaxLength(50)]
        public string MedicalInsurance { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
        public ICollection<Appointment> Appoitments { get; set; } = new List<Appointment>();
    }
}

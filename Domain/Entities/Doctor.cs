using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor : User
    {
        [Required]
        public Speciality Speciality { get; set; }
        public int LicenseNumber { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Appointment> AssignedAppointment { get; set; } = new List<Appointment>();

    }
}

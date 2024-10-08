using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Office { get; set; } = string.Empty;
        public AppointmentStatus Status { get; set; }

        //Relación con pacientes y doctores
        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }


    }
}

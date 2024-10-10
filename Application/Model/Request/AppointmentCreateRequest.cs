using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Request
{
    public class AppointmentCreateRequest
    {
        
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        
        //public TimeSpan Time {  get; set; }
        public string Office {  get; set; } = string.Empty;
    }
}

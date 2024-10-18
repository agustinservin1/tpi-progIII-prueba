using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        //public TimeSpan Time { get; set; }
        public string Office { get; set; } = string.Empty;
        //public AppointmentStatus Status { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public AppointmentStatus Status { get; set; }
        public static AppointmentDto CreateAppointmentDto(Appointment appointment)
        {
           
            var newAppointment = new AppointmentDto()
            {
                Id = appointment.Id,
                Date = appointment.Date,
                Office = appointment.Office,
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId,
                Status = appointment.Status
            };
            return newAppointment;
         }
        public static IEnumerable<AppointmentDto> CreateListDto(IEnumerable<Appointment> appointments)
        {
            List<AppointmentDto> list = new List<AppointmentDto>();
            foreach (Appointment a in  appointments) 
                {
                   list.Add(CreateAppointmentDto(a));
                }
                return list;
        }
     }
}

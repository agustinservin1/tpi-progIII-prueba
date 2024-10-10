using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAppointmentRepository : IBaseRepository<Appointment>
    {
        Appointment? GetAppointmentByIdWithPatientAndDoctor(int id);
        Appointment? DeleteAppointment(int id);//DeleteAppointmentById
        IEnumerable<Appointment> GetAppointmentsDoctorById(int id);
        IEnumerable<Appointment> GetAppointmentsPatientById(int id);

    }
}

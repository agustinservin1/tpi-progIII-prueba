using Application.Model;
using Application.Model.Request;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAppointmentService
    {
        AppointmentDto GetById(int id);
        AppointmentDto CreateAppointment(AppointmentCreateRequest appointment);
        AppointmentDto UpdateAppointment(int id, AppointmentUpdateRequest appointment);
        AppointmentDto DeleteAppointment(int id);
        IEnumerable<AppointmentDto> GetAppointmentsDoctorById(int id);
        IEnumerable<AppointmentDto> GetAppointmentsPatientById(int id);
        AppointmentDto CanceledAppointment(int id);

    }
}

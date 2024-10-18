using Application.Interfaces;
using Application.Model;
using Application.Model.Request;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;

        }
        public AppointmentDto GetById(int id) {
            var appointment = _appointmentRepository.GetAppointmentByIdWithPatientAndDoctor(id);
            return AppointmentDto.CreateAppointmentDto(appointment);
        }
        public AppointmentDto CreateAppointment(AppointmentCreateRequest appointment)
            {
           
            var newAppointment = new Appointment()
            {
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId,
                Date = appointment.AppointmentDate,
                Office = appointment.Office
            };
            
            var entity = _appointmentRepository.Create(newAppointment);
            return AppointmentDto.CreateAppointmentDto(entity);
            }
        public AppointmentDto UpdateAppointment(int id, AppointmentUpdateRequest appointment)
            {
                var appointmentUpdate = _appointmentRepository.GetById(id);

                appointmentUpdate.PatientId = appointment.PatientId;
                appointmentUpdate.DoctorId = appointment.DoctorId;
                appointmentUpdate.Date = appointment.AppointmentDate;

                var entity = _appointmentRepository.Update(appointmentUpdate);
                return AppointmentDto.CreateAppointmentDto(entity);
            }
        public AppointmentDto DeleteAppointment(int id)
        {
            var entity = _appointmentRepository.DeleteAppointment(id);
            return AppointmentDto.CreateAppointmentDto(entity);

        }

        public IEnumerable<AppointmentDto> GetAppointmentsDoctorById(int id)
        {
            var appointemnts = _appointmentRepository.GetAppointmentsDoctorById(id);
        
            return AppointmentDto.CreateListDto(appointemnts);
        }
        public IEnumerable<AppointmentDto> GetAppointmentsPatientById(int id)
        {
            var appointments = _appointmentRepository.GetAppointmentsPatientById(id);

            return AppointmentDto.CreateListDto(appointments);
        }
        public AppointmentDto CanceledAppointment(int id)
        {
            var appointment = _appointmentRepository.GetById(id);
            appointment.Status = AppointmentStatus.Canceled;
            var entity =_appointmentRepository.Update(appointment);
            return AppointmentDto.CreateAppointmentDto(entity);
        }
    }


    }


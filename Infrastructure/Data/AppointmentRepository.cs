using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        private readonly ApplicationContext _context;
        public AppointmentRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public Appointment? GetAppointmentByIdWithPatientAndDoctor(int id)
        {
         var appointment= _context.Appointments
                            .Include(c=>c.Patient)
                            .Include(c=>c.Doctor)
                            .FirstOrDefault(c=>c.Id== id);
            return appointment;
        }

        public Appointment? DeleteAppointment (int id)
        {
            var entity  = _context.Appointments
                               .Include(c=>c.Doctor)
                               .Include(c=>c.Patient)
                               .FirstOrDefault (c=>c.Id== id);
            var appointment = _context.Appointments.Remove(entity);
            _context.SaveChanges();
            return entity;
        }
        public IEnumerable<Appointment>GetAppointmentsDoctorById(int id)
        {
            var appointments = _context.Appointments.Where(c=>c.DoctorId== id)
                                        .Include(u => u.Doctor)
                                        .Include(u => u.Patient)
                                        .ToList();
            return appointments;
        }
        public IEnumerable<Appointment> GetAppointmentsPatientById(int id)
        {
            var appointments = _context.Appointments.Where(c => c.PatientId == id)
                                        .Include(u => u.Doctor)
                                        .Include(u => u.Patient)
                                        .ToList();
            return appointments;
        }
     
    }
}

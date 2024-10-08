using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly ApplicationContext _context;
        public PatientRepository(ApplicationContext context) : base(context) 
        {
            _context = context;
        }
        public  Patient? GetByIdIncludeAddress(int id)
        {
            var entity = _context.Patients
                                 .Include(a=>a.Address)
                                 .FirstOrDefault(c => c.Id == id);
            var patient = _context.Patients.Remove(entity);
            _context.SaveChanges();
            return entity;
        }
        public IEnumerable<Patient> GetAllPatientWithAddress()
        {
            var list = _context.Patients
                              .Include(a => a.Address)
                              .ToList();
            return list;
        }
        public Patient DeletePatient(int id)
        {
            var entity = _context.Patients
                                    .Include(a => a.Address)
                                    .FirstOrDefault(a => a.Id == id);

            var patient = _context.Patients.Remove(entity);
            _context.SaveChanges();
            return entity;
        }





    }
}


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
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        private readonly ApplicationContext _context;

        public DoctorRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
        public Doctor? GetByIdIncludeAddress(int id)
        {
            var entity = _context.Doctors
                                 .Include(a=>a.Address)
                                 .FirstOrDefault(d => d.Id == id);
            return entity;
        }
        public IEnumerable<Doctor> GetAllDoctorsWithAddress()
        {
            var list = _context.Doctors
                    .Include(a=>a.Address)  
                    .ToList();
            return list;
        }
        public Doctor DeleteDoctor (int id)
        {
            var entity = _context.Doctors
                        .Include (a=>a.Address)
                        .FirstOrDefault(d => d.Id == id);
            var doctors = _context.Doctors.Remove(entity);   
            _context.SaveChanges();
            return entity;  
        }
    }
}

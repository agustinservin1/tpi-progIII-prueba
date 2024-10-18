using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        Doctor? GetById(int id);
        IEnumerable<Doctor> GetAllDoctors();
        Doctor DeleteDoctor (int id);
        IEnumerable<Doctor> GetDoctorsBySpecialty(Specialty specialty);


    }
}

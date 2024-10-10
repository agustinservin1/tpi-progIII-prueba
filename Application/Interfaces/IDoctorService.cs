using Application.Model;
using Application.Model.Request;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDoctorService
    {
        DoctorDto GetById(int id);
        IEnumerable<DoctorDto> GetAllDoctors();
        DoctorDto CreateDoctor(DoctorCreateRequest doctor);
        DoctorDto UpdateDoctor(int id, UpdateDoctorRequest doctor);
        DoctorDto DeleteDoctor(int id);
        IEnumerable<DoctorDto> GetBySpecialty(Specialty specialty);
    }
}

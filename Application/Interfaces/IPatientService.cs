using Application.Model;
using Application.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        PatientDto? GetPatientById(int id);
        IEnumerable<PatientDto> GetAllPatients();
        PatientDto CreatePatient(PatientCreateRequest patient);
        PatientDto UpdatePatient(int id, UpdatePatientRequest patient);
        PatientDto DeletePatient(int id);

    }
}

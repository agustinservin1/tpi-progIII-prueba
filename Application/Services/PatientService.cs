using Application.DTO;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService (IPatientRepository patient)
        {
            _patientRepository = patient;
        }
       public Patient? GetById(int id)
        {
            return _patientRepository.GetById(id);
        }
        public IEnumerable<Patient> GetAll() { 
            return _patientRepository.GetAll();
            }

        public Patient CreatePatient(PatientForRequest patient)
        {
        //    var newAddress = new Address()
        //    {
        //        Street = address.Street,
        //        Province = address.Province,
        //        City = address.City,
        //        PostalCode = address.PostalCode,

        //    };

            var entity = new Patient()
            {
                Name = patient.Name,
                LastName = patient.LastName,
                PhoneNumber = patient.PhoneNumber,
                DateOfBirth = patient.DateOfBirth,
            };

            return _patientRepository.Create(entity);
         }

        public Patient UpdatePatient(PatientForRequest patient, int id)
        {
            var entity = _patientRepository.GetById(id);
            if (entity == null){
                throw new ArgumentException("No se encontró paciente");
             }

            entity.Name = patient.Name;
            entity.LastName = patient.LastName;
            entity.PhoneNumber = patient.PhoneNumber;
            entity.DateOfBirth = patient.DateOfBirth;
            


            return entity;
        }
    }
}

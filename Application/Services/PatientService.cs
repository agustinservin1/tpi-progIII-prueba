using Application.Interfaces;
using Application.Model;
using Application.Model.Request;
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
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IAddressRepository _addresRepository;        
        public PatientService (IPatientRepository patient, IAddressRepository addressRepository)
        {
            _patientRepository = patient;
            _addresRepository = addressRepository;
     
        }

        public PatientDto? GetPatientById(int id)
        {
            var patient= _patientRepository.GetByIdIncludeAddress(id);
            return PatientDto.CreatePatient(patient);
        }
        public IEnumerable<PatientDto> GetAllPatients()
        {
            var listPatient = _patientRepository.GetAllPatientWithAddress();
            return PatientDto.CreateList(listPatient);
        }

        public PatientDto CreatePatient(PatientCreateRequest patient)
        {
            var newAdress = new Address()
            {
                Street = patient.Address.Street,
                PostalCode = patient.Address.PostalCode,
                City = patient.Address.City,
                Province = patient.Address.Province,
            };

            var entity = new Patient()
            {
                Name = patient.Name,
                LastName = patient.LastName,
                PhoneNumber = patient.PhoneNumber,
                DateOfBirth = patient.DateOfBirth,
                MedicalInsurance = patient.MedicalInsurance,
                Address = newAdress,
                Email = patient.Email,
                Password = patient.Password,
            };

           
                var newEntity = _patientRepository.Create(entity);
                return PatientDto.CreatePatient(newEntity);
            }
        public PatientDto UpdatePatient(int id, UpdatePatientRequest patient)
        {
            var entity = _patientRepository.GetById(id);

            entity.Name = patient.Name;
            entity.LastName = patient.LastName;
            entity.PhoneNumber = patient.PhoneNumber;
            entity.DateOfBirth = patient.DateOfBirth;
            entity.MedicalInsurance = patient.MedicalInsurance;

            var newEntity = _patientRepository.Update(entity);
            return PatientDto.CreatePatient(newEntity);
        }

        public PatientDto DeletePatient(int id)
        {
            var entity = _patientRepository.DeletePatient(id);
            return PatientDto.CreatePatient(entity);
           
        }

    }
      

    }


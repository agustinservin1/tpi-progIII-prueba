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
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IAddressRepository _addressRepository;
        public DoctorService (IDoctorRepository repository, IAddressRepository addressRepository)
        {
            _repository = repository;
            _addressRepository = addressRepository;
        }
        public DoctorDto GetById (int id) {

            var doctor = _repository.GetById(id);
            return DoctorDto.CreateDoctorDto(doctor);
        }
        public IEnumerable<DoctorDto> GetAllDoctors()
        {
            var list = _repository.GetAllDoctors();
            return DoctorDto.CreatelistDto(list);
        }
        public DoctorDto CreateDoctor(DoctorCreateRequest doctor)
        {
      

            var entity = new Doctor()
            {
                Name = doctor.Name,
                LastName = doctor.LastName,
                PhoneNumber = doctor.PhoneNumber,
                DateOfBirth = doctor.DateOfBirth,
                Specialty = doctor.Specialty,
                LicenseNumber = doctor.LicenseNumber,
                Email = doctor.Email,
                Password = doctor.Password,
            };
            
                var newEntity = _repository.Create(entity);
                return DoctorDto.CreateDoctorDto (newEntity);
             }  
        public DoctorDto UpdateDoctor(int id, UpdateDoctorRequest doctor)
            {
                var entity = _repository.GetById(id);

                entity.Name = doctor.Name;
                entity.LastName = doctor.LastName;
                entity.PhoneNumber = doctor.PhoneNumber;
                entity.DateOfBirth = doctor.DateOfBirth;
                entity.Specialty = doctor.Specialty;
                entity.LicenseNumber = doctor.LicenseNumber;

                var newEntity = _repository.Update(entity);
                return DoctorDto.CreateDoctorDto(newEntity);
            }
            
            
        public DoctorDto DeleteDoctor(int id)
        {                
                var entity = _repository.DeleteDoctor(id);
                return DoctorDto.CreateDoctorDto(entity);

        }
        public IEnumerable<DoctorDto> GetBySpecialty(Specialty specialty)
        {
           var doctors = _repository.GetDoctorsBySpecialty(specialty);
           return DoctorDto.CreatelistDto(doctors);
        }

        }
    }

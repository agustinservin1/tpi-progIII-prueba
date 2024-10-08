using Application.Model;
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
        private readonly IDoctorRepository _doctorRepository;
        
        public PatientService (IPatientRepository patient, IDoctorRepository doctorRepository)
        {
            _patientRepository = patient;
            _doctorRepository = doctorRepository;
     
        }

        public PatientDto? GetPatientById(int id)
        {
            var patient= _patientRepository.GetByIdIncludeAddress(id);
            return PatientDto.CreatePatient(patient);
        }






        //public appointment createappointment(appointmentcreaterequest appointmentcreaterequest)
        //{
        //    var patient = _patientrepository.getbyid(appointmentcreaterequest.patientid);
        //    var doctor = _doctorrepository.getbyid(appointmentcreaterequest.doctorid);
        //    var appointment = new appointment
        //    {
        //        patientid = patient.iduser,
        //        iddoctor = doctor.iduser,
        //        date = appointmentcreaterequest.appointmentdate

        //    };

        //    _appointmentrepository.create(appointment);
        //    return appointment;
        //}

    }
      

    }


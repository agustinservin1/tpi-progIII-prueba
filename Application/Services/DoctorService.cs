using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IAddressRepository _addressRepository;
    public DoctorService (IDoctorRepository repository, IAddressRepository addressRepository)
        {
            _repository = repository;
            _addressRepository = addressRepository;
        }
    
    }
}

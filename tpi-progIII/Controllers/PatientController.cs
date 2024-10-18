using Application.Interfaces;
using Application.Model.Request;
using Application.Services;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;
        private readonly IUserRepository _userRepository;
        public PatientController(IPatientService service, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetPatientById(id));
        }

        [HttpGet ("/Patients")]
        public IActionResult GetPatients()
        {
            return Ok(_service.GetAllPatients());
        }

        [HttpPost]
        [Authorize(Policy = "Patient")]
        public IActionResult AddPatient([FromBody] PatientCreateRequest request)
        {
            return Ok(_service.CreatePatient(request));
        }

        [HttpPut("/UpdatePatient/{id}")]
        [Authorize(Policy = "Doctor")]
        public IActionResult UpdatePatient(int id, [FromBody] UpdatePatientRequest request)
        {
            return Ok(_service.UpdatePatient(id, request));
        }

        [HttpDelete("/DeletePatient/{id}")]
        [Authorize(Policy = "Admin")]

        public IActionResult DeletePatient(int id)
        {
            return Ok(_service.DeletePatient(id));
        }
        
       
    }
}


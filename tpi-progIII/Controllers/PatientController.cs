using Application.Interfaces;
using Application.Model.Request;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
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
        public IActionResult AddPatient([FromBody] PatientCreateRequest request)
        {
            return Ok(_service.CreatePatient(request));
        }

        [HttpPut("/UpdatePatient/{id}")]
        public IActionResult UpdatePatient(int id, [FromBody] UpdatePatientRequest request)
        {
            return Ok(_service.UpdatePatient(id, request));
        }

        [HttpDelete("/DeletePatient/{id}")]

        public IActionResult DeletePatient(int id)
        {
            return Ok(_service.DeletePatient(id));
        }
    }
}


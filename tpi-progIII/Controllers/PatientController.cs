using Application.DTO;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService _patientService;
        public PatientController(PatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet ("/{id}")]
        public IActionResult GetById(int id)
        {
           return Ok(_patientService.GetById(id));
        }
        [HttpPost]
        public IActionResult AgregarPaciente([FromBody] PatientForRequest request)
        {
            return Ok(_patientService.CreatePatient(request));
        }
        [HttpGet ("/GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_patientService.GetAll());
        }

    }
}

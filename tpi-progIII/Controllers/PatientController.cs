using Application.Model;
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
           
        //[HttpPost]
        //public IActionResult CreateAppointment([FromBody] AppointmentCreateRequest appointment)
        //{
        //    return (Ok(_patientService.CreateAppointment(appointment)));
                
        // }

    }
}

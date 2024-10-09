using Application.Interfaces;
using Application.Model.Request;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("/Appointment/{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok(_appointmentService.GetById(id));
        }
        [HttpPost("/CreateAppointment")]
        public IActionResult CreateAppointment(AppointmentCreateRequest request)
        {
            return Ok(_appointmentService.CreateAppointment(request));
        }
    }
}

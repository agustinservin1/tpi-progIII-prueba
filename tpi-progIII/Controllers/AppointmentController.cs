using Application.Interfaces;
using Application.Model.Request;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        public IActionResult CreateAppointment([FromBody]AppointmentCreateRequest request)
        {
            return Ok(_appointmentService.CreateAppointment(request));
        }
        [HttpPut ("/AppointmentPut")]
        public IActionResult UpdateAppointment(int id, [FromBody]AppointmentUpdateRequest request)
        {
            return Ok(_appointmentService.UpdateAppointment(id, request));
        }
        [HttpDelete ("/AppointmentDelete")]
        public IActionResult DeleteAppointment(int id)
        {   
            return Ok(_appointmentService.DeleteAppointment(id));
        }
        [HttpGet("/AppointmentsByIdDoctor/{id}")]
        public IActionResult GetAppointmentsByDoctors(int id)
        {
            return Ok(_appointmentService.GetAppointmentsDoctorById(id));
        }

        [HttpGet("/AppointmentsByIdPatient/{id}")]
        public IActionResult GetAppointmentsByPatients(int id)
        {
            return Ok(_appointmentService.GetAppointmentsPatientById(id));
        }
        [HttpPost ("/CanceledAppointmentStatus/{id}")]
        public IActionResult CanceledAppointment(int id)
        {
            return Ok(_appointmentService.CanceledAppointment(id));
        }
    }
}

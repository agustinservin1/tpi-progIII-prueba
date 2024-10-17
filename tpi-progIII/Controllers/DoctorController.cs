using Application.Interfaces;
using Application.Model.Request;
using Application.Services;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DoctorController : ControllerBase
    {
     private readonly IDoctorService _service;
        public DoctorController(IDoctorService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpGet("/Doctors")]
        public IActionResult GetDoctors()
        {
            return Ok(_service.GetAllDoctors());
        }

        [HttpPost]
        public IActionResult AddDoctor([FromBody] DoctorCreateRequest request)
        {
            return Ok(_service.CreateDoctor(request));
        }

        [HttpPut("/UpdateDoctor/{id}")]
        public IActionResult UpdateDoctor(int id, [FromBody] UpdateDoctorRequest request)
        {
            return Ok(_service.UpdateDoctor(id, request));
        }

        [HttpDelete("/DeleteDoctor/{id}")]

        public IActionResult DeleteDoctor(int id)
        {
            return Ok(_service.DeleteDoctor(id));
        }
        [HttpGet ("/GetDoctorsBySpecialty/")]
        public IActionResult GetDoctorsBySpecialty([FromQuery]Specialty specialty) {
            return Ok(_service.GetBySpecialty(specialty));    
        }

    }
}

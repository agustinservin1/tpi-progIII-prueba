﻿using Application.Model.Request;
using Application.Services;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
     private readonly DoctorService _service;
        public DoctorController(DoctorService service)
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

        [HttpPut("/{id}")]
        public IActionResult UpdateDoctor(int id, [FromBody] UpdateDoctorRequest request)
        {
            return Ok(_service.UpdateDoctor(id, request));
        }

        [HttpDelete("/{id}")]

        public IActionResult DeleteDoctor(int id)
        {
            return Ok(_service.DeleteDoctor(id));
        }

    }
}

using Application.Interfaces;
using Application.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace tpi_progIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticateService;
        public AuthenticationController(IAuthenticationService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public IActionResult AuthenticateUser([FromBody] CredentialRequest request)
        {
           return Ok("jwt");
        }
    }
}

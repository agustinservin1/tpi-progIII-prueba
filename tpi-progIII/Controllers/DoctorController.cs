using Microsoft.AspNetCore.Mvc;

namespace tpi_progIII.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

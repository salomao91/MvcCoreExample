using Microsoft.AspNetCore.Mvc;
using MvcCoreExample.Models;

namespace MvcCoreExample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

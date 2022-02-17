using HospitalAppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentScheduler.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

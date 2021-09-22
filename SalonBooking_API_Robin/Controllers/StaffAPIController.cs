using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonBooking_API_Robin.Controllers
{
    public class StaffAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

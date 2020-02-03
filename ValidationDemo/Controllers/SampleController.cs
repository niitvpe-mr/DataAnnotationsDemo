using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;
namespace ValidationDemo.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            StudentModel student = new StudentModel();

            return View();
        }

        [HttpPost]
        public string Index(int id)
        {
            return "Registered successfully!!!";
        }
    }
}
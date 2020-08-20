using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientLibrary;

namespace MVCProject.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult MySubmit(Patient obj)
        {
            //Patient obj = new Patient();
           
            //obj.name = Request.Form["txtname"];             
            //obj.address = Request.Form["txtaddress"];      

            return View("PatientDisplay",obj);
        }
    }
}

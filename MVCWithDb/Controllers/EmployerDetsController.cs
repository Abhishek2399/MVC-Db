using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DALPro;
using DALPro.Models;

namespace MVCWithDb.Controllers
{

    public class EmployerDetsController : Controller
    {
        private EmployerDAL emplrDb;

        public EmployerDetsController()
        {
            emplrDb = new EmployerDAL();
        }
        public IActionResult ShowAllEmployers()
        {
            IEnumerable<Employer> emprs = emplrDb.ShowEmployers();
            return View(emprs);
        }

        // We need two action methods to take input from user and do something with database

        [HttpGet]
        public IActionResult ShowEmployerByID()
        {
            return View();
        }

        [HttpPost] // can be called by form only
        public IActionResult ShowEmployerByID(int eid)
        {
            Employer searched = emplrDb.ShowEmplyerByID(eid);
            return View("ShowEmployerDetails", searched);
        }

        [HttpGet]
        public IActionResult AddEmployer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployer(Employer obj)
        {
            if (obj != null)
            {
                TempData["Err"] = "Not Inserted Faced Issues";
            }
            else
            {
                if (emplrDb.AddEmployer(obj))
                {
                    return RedirectToAction("ShowAllEmployers");
                }
                else
                {
                    TempData["Err"] = "Not Inserted Faced Issues";
                }
            }
            return View();
        }

         [HttpGet]   
         public IActionResult DeleteEmployer()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DeleteEmployer(int eid)
        {
            TempData["err"] = "";
            if (emplrDb.DeleteEmployer(eid))
            {
                return RedirectToAction("ShowAllEmployers");
            }
            else
            {
                TempData["err"] = "Error : Record not Found";
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithDb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult TestAction()
        {
            return Content("this is test");
        }
    }
}

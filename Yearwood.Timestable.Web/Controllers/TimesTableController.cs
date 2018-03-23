using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Yearwood.Timestable.Web.Controllers
{
    public class TimesTableController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(bool startTimer)
        {
            Stopwatch s = Stopwatch.StartNew();


            return View();

        }

    }
}
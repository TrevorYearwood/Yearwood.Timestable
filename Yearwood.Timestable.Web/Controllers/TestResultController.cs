using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Yearwood.Timestable.Services;
using Yearwood.Timestable.Web.ViewModel;

namespace Yearwood.Timestable.Web.Controllers
{
    public class TestResultController : Controller
    {
        private readonly IDataService _dataService;

        public TestResultController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            var model = new TestResultsViewModel
            {


                TestResults = _dataService.GetAll()
            };
            return View(model);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Controllers
{
    public class JobPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

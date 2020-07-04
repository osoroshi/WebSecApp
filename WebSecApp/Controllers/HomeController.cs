using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSecApp.Models;
using WebSecApp.ViewModels;

namespace WebSecApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISecserviceRepository _secservicerepository;

        public HomeController(ISecserviceRepository secservicerepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _secservicerepository = secservicerepository;
        }

        public ViewResult List()
        {

            SecServiceListViewModel secservicelistviewmodel = new SecServiceListViewModel();
            secservicelistviewmodel.SecServices = _secservicerepository.AllSecService;
            return View(secservicelistviewmodel);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

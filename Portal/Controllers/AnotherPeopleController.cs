using System;
using ApplicationLogic;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class AnotherPeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public AnotherPeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService ?? throw new ArgumentNullException(nameof(peopleService));
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
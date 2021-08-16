using System;
using DataAccess;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonDAO _personDao;

        public PeopleController(IPersonDAO personDao)
        {
            _personDao = personDao ?? throw new ArgumentNullException(nameof(personDao));
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoSomething()
        {
            _personDao.SavePerson(new Person());

            return Ok();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(List<Person> people)
        {
            return Redirect("/home/index");
        }

    }
}
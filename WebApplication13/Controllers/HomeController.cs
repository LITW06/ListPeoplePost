using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleList.Data;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mgr = new PersonManager(Properties.Settings.Default.ConStr);
            return View(mgr.GetPeople());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(IEnumerable<Person> people)
        {
            var mgr = new PersonManager(Properties.Settings.Default.ConStr);
            mgr.AddPeople(people);
            return Redirect("/home/index");
        }

        

    }
}
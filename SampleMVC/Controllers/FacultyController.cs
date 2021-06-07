using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        private SampleDBContext dBContext;
        public FacultyController()
        {
            dBContext = new SampleDBContext();
        }
        public ActionResult Index()
        {
            
            return View(dBContext.Faculties);
        }
    }
}
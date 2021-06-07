using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private SampleDBContext dBContext;
        public StudentController()
        {
            dBContext = new SampleDBContext();
        }
        public ActionResult Index()
        {
            var students = dBContext.Students;
            
            return View(students);
        }
        public ActionResult Details(int id)
        {
            var student = dBContext.Students.SingleOrDefault(s => s.Id == id);
            return View(student);
        }
    }
}
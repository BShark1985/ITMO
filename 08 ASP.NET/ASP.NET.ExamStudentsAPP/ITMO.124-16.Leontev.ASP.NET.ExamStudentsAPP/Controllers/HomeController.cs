using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ITMO._124_16.Leontev.ASP.NET.ExamStudentsAPP.Models;

namespace ITMO._124_16.Leontev.ASP.NET.ExamStudentsAPP.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            GiveStudents();
            return View();
        }

        public ActionResult About()
        {
            GiveStudents();
            return View();
        }

        public ActionResult Top5()
        {
            GiveStudents();
            return View();
        }

        private void GiveStudents()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            GiveStudents();
            return View();
        }

        [HttpPost]
        public string CreateStudent(Student newStudent)
        {
            // Добавляем нового студента в БД
            db.Students.Add(newStudent);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо за заполение данных!";
        }
    }
}
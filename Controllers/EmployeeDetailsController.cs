using EmployeeDetails.Data;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class EmployeeDetailsController : Controller
    {


        private readonly EmployeeDetailsDbContext _context;



        public EmployeeDetailsController(EmployeeDetailsDbContext context)
        {
            _context = context;
        }




        public IActionResult Index()
        {
            List<Employee> employees;
            employees = _context.Applicants.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Employee employees = new Employee();
            
            return View(employees);
        }

        [HttpPost]
        public IActionResult Create(Employee employees)
        {

            
            _context.Add(employees);
            _context.SaveChanges();
            return RedirectToAction("index");

        }
    }
}

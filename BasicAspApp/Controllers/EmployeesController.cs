using BasicAspApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BasicAspApp.Controllers
{
    public class EmployeesController: Controller
    {
        /*
         * Setup DBContext injection in the controllers need DB access.
         */
        private readonly BasicAspDBContext _context;
        public EmployeesController(BasicAspDBContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            var model = new EmployeesPageViewModel();
            SQLEmployeeData sqlData = new SQLEmployeeData(_context);
            model.Employees = sqlData.GetAll();
            return View(model);
        }
        public ViewResult Detail(int id)
        {
            var model = new EmployeesPageViewModel();
            SQLEmployeeData sqlData = new SQLEmployeeData(_context);
            Employee employee = sqlData.Get(id);
            ViewBag.str1 = "This message is transfered from controller to view by ViewBag.";
            return View(employee);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
    }

    public class SQLEmployeeData
    {
        private BasicAspDBContext _context { get; set; }

        public SQLEmployeeData(BasicAspDBContext context)
        {
            _context = context;
        }

        public void Add(Employee emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }

        public Employee Get(int Id)
        {

            return _context.Employees.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList<Employee>();
        }
    }

    public class EmployeesPageViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownExample.Models;
namespace DropDownExample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppicationDbContext _context = new AppicationDbContext();
        // GET: Employee
        public ActionResult Create()
        {
            var viewModel = new EmployeeViewModel
            {
                departments=_context.Departments.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(EmployeeViewModel model)
        {
            if(ModelState.IsValid)
            {
                // Process the data as needed
                return RedirectToAction("Create");
            }
            // Rebind the dropdown list in case of validation errors
            model.departments = _context.Departments.ToList();
            return View(model);
        }
    }
}
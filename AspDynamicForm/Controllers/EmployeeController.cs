using AspDynamicForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDynamicForm.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService _service = new EmployeeService();
        // GET: Employee
        public ActionResult Index()
        {
            var result = _service.Get();
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Models.Employee employee)
        {
            _service.Update(employee.ID, employee);
            return Json(new { IsSuccess = true, Url= Url.Action("Index","Employee")});
        }
    }
}
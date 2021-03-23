using System.Collections.Generic;
using DependencyInjection1.Models.Repository;
using DependencyInjection1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection1.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IDataRepository<Employee> _dataRepository;

		public EmployeeController(IDataRepository<Employee> dataRepository)
		{
			_dataRepository = dataRepository;
		}

        public IActionResult Index()
        {

            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return View(employees);
        }
        //public IActionResult Index([FromServices] IDataRepository<Employee> _dataRepository)
        //{
        //	IEnumerable<Employee> employees = _dataRepository.GetAll();
        //	return View(employees);
        //}

        [HttpPost]
		public IActionResult Add(Employee employee)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);

			}

			_dataRepository.Add(employee);
			return RedirectToAction(actionName: nameof(Index));
		}
	}
}
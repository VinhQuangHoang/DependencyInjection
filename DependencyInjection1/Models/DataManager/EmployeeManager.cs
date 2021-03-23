using DependencyInjection1.Models.Repository;
using System;
using System.Collections.Generic;

namespace DependencyInjection1.Models.DataManager
{
	public class EmployeeManager : IDataRepository<Employee>
	{
		public void Add(Employee employee)
		{
			throw new NotImplementedException();
		}

		IEnumerable<Employee> IDataRepository<Employee>.GetAll()
		{
			return new List<Employee>() {
				new Employee()
			};
		}
	}
}

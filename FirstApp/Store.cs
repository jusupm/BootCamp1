using System;
namespace FirstApp
{
	public class Store
	{
		public Store()
		{
		}
		private float Expanses { get; set; }
		public List<IEmployee> Employees = new List<IEmployee>();

		public float CalculateTotalExpnses(List<IEmployee> Employees) {
			foreach(Employee employee in Employees)
			{
				Expanses += employee.CalculateSalary(employee.WorkingHours, employee.PayRate);
			}
			return Expanses;
		}
	}
}


using System;
namespace FirstApp
{
	public class Manager : Employee
	{
		private float Bonus { get; set; }
		public Manager(string FirstName, string LastName, int WorkingHours, float PayRate, float Bonus)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.WorkingHours = WorkingHours;
			this.PayRate = PayRate;
			this.Bonus = Bonus;
		}
        public override float CalculateSalary(int workingHours, float payRate)
        {
			return workingHours * payRate + Bonus;
        }
    }
}


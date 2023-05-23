using System;
namespace FirstApp
{
	public abstract class Employee : IEmployee
	{
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int WorkingHours { get; set; }
        public float PayRate { get; set; }

        public virtual float CalculateSalary(int workingHours, float payRate)
        {
            return workingHours * payRate;
        }

    }
}


using System;
namespace FirstApp
{
	public class Cashier : Employee
	{
        public Cashier(string FirstName, string LastName, int WorkingHours, float PayRate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.WorkingHours = WorkingHours;
            this.PayRate = PayRate;
        }
    }
}


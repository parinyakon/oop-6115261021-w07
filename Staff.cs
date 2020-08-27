using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w07
{
    class Staff : Person
    {
        private double performanceLevel;
        
        public double PerformanceLevel { get => performanceLevel; set => performanceLevel = value; }
        
        public Staff(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin, double pl)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.PerformanceLevel = pl;
           
        }
        public double calculateSalaryRaise()
        {
            double score = this.PerformanceLevel + this.AssessedFromAdmin + this.IntentYearlyActivity;
            double salaryRaise = 0;

            if (score < 70)
            {
                return 0;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.015;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.02;
            }
            else if (score <= 95)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 95)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Raise Staff : " + this.calculateSalaryRaise();
        }
    }
}

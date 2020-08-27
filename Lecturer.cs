using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w07
{
    class Lecturer : Person
    {
        private double qualityOfWork;
        private double numberOfProjects;
        private double numberOfResearches;

        public double QualityOfWork { get => qualityOfWork; set => qualityOfWork = value; }
        public double NumberOfProjects { get => numberOfProjects; set => numberOfProjects = value; }
        public double NumberOfResearches { get => numberOfResearches; set => numberOfResearches = value; }

        public Lecturer(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin, double qow, double nop, double nor) {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.QualityOfWork = qow;
            this.NumberOfProjects = nop;
            this.NumberOfResearches = nor;
    }
        public double calculateSalaryRaise()
        {
            double score = this.QualityOfWork + this.NumberOfProjects + this.NumberOfResearches + this.AssessedFromAdmin + this.IntentYearlyActivity;
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
                salaryRaise = Salary * 0.02;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 90)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Raise Lecturer : " + this.calculateSalaryRaise();
        }
    }
}

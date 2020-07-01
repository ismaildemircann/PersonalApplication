using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class Salary_
    {
        private double initialSalary = 5000;
        private double experienceYear = 0;
        private double province = 0;
        private double degree = 0;
        private double foreignLanguage = 0;
        private double managementPosition = 0;
        private double statusFamily = 0;

        public double InitialSalary { get => initialSalary; set => initialSalary = value; }
        public double ExperienceYear { get => experienceYear; set => experienceYear = value; }
        public double Province { get => province; set => province = value; }
        public double Degree { get => degree; set => degree = value; }
        public double ForeignLanguage { get => foreignLanguage; set => foreignLanguage = value; }
        public double ManagementPosition { get => managementPosition; set => managementPosition = value; }
        public double StatusFamily { get => statusFamily; set => statusFamily = value; }
    }

    public abstract class SalaryBuilder
    {
        protected Salary_ _Salary = new Salary_();

        public Salary_ Salary
        {
            get { return _Salary; }
        }

        public abstract double CalculateSalary();
    }

    public class UserSalary
        : SalaryBuilder
    {
        public override double CalculateSalary()
        {
            return Salary.InitialSalary * (Salary.ExperienceYear + Salary.Province + Salary.Degree
                + Salary.ForeignLanguage + Salary.ManagementPosition + Salary.StatusFamily + 1);
        }
    }

    public class PartTimeUserSalary
       : SalaryBuilder
    {
        public override double CalculateSalary()
        {
            return (Salary.InitialSalary / 2) * (Salary.ExperienceYear + Salary.Province + Salary.Degree
                + Salary.ForeignLanguage + Salary.ManagementPosition + Salary.StatusFamily + 1);
        }
    }

    public class SalaryDirector
    {
        public double Calculate(SalaryBuilder vBuilder)
        {
            return vBuilder.CalculateSalary();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC10
{
    class CompanyEmpWage
    {

        private string company;
        public int emprateperhr;
        public int NumOfWorkingPerDays;
        public int MaxHourPerMonth;
        public int TotalEmpWage;

        public int salary;


        public CompanyEmpWage(string company, int emprateperhr, int NumOfWorkingDays, int MaxHourPerMonth, int salary)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.NumOfWorkingPerDays = NumOfWorkingPerDays;
            this.MaxHourPerMonth = MaxHourPerMonth;
            this.salary = salary;

        }


        public void setTotalEmpWage(int TotalEmpwage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }





    }
}
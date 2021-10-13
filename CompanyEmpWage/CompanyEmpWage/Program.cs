using System;

namespace CompanyEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Calculation for different Companies");

            Company company1 = new Company("DMart",15,4,100) ;      //Companyname,wageperhr,workingdays,maxhrs
            Company company2 = new Company("Reliance", 20, 4, 80);
            Company company3 = new Company("Apple", 25, 5, 60);

            Console.WriteLine("Enter company name to get Total Wage : ");
            var name = Console.ReadLine();
            
            int total = EmployeeWage.getTotalWage(name);
            Console.WriteLine("Total wage for " + name + " is " + total);



        }
    }
}

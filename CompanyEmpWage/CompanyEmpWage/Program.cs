using System;

namespace CompanyEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Calculation for different Companies");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CalculateEmployeeAttendance();
            employeeWage.CalculateDaillyEmpWage();
            employeeWage.PartTimeWage();
            employeeWage.EmpWageinswitch();
            employeeWage.EmpWagePerMonth();
            employeeWage.EmpWageinCondition();
            EmployeeWage.CalculationEmpWage();
            
        }
    }
}

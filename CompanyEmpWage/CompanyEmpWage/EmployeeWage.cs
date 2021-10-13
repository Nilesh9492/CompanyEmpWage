using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyEmpWage
{
    class EmployeeWage
    {
                
            const int isAbsent = 1;
            const int wagesPerHr = 20;
            const int isPresent = 1;
            const int isPartTime = 2;
            const int totalWorkingDays = 20;
            const int maxHrsMonth = 100;
            const int numberOfWorkingDays = 20;

            public void CalculateEmployeeAttendance()
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == isPresent)
                    Console.WriteLine("Employee is present");
                else
                    Console.WriteLine("Employee is absent");

            }
            public void CalculateDaillyEmpWage()
            {
                int totalWagePerDay = 0;
                int isFullTime = 1;

                int empworkinghrsperday = 0;
                int wagepertotalhours = 0;
                Random random = new Random();
                int empcheck = random.Next(0, 2);
                if (empcheck == 1)
                {
                    empworkinghrsperday = 8;
                    Console.WriteLine("Employee workinghour per day: " + empworkinghrsperday);

                }
                else
                {
                    empworkinghrsperday = 0;
                    Console.WriteLine("Employee working hour per day : " + empworkinghrsperday);

                }
                totalWagePerDay = empworkinghrsperday * wagesPerHr;
                Console.WriteLine("Employee Wage of full day : " + totalWagePerDay);
            }
            public void PartTimeWage()
            {
                int empWorkingHoursPerDay = 0;
                int empWagePerDay = 0;

                Random random = new Random();

                int empCheck = random.Next(0, 3);

                if (empCheck == isPartTime)
                {
                    empWorkingHoursPerDay = 4;
                }
                else if (empCheck == isPresent)
                {
                    empWorkingHoursPerDay = 8;
                }
                else
                {
                    empWorkingHoursPerDay = 0;
                }
                empWagePerDay = empWorkingHoursPerDay * wagesPerHr;
                Console.WriteLine("Employee Wage of the day : " + empWagePerDay);
            }
            public void EmpWageinswitch()
            {
                int empWorkingHoursPerDay = 0;
                int empWagePerDay = 0;

                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isPartTime:
                        empWorkingHoursPerDay = 4;
                        break;
                    case isPresent:
                        empWorkingHoursPerDay = 8;
                        break;
                    default:
                        empWorkingHoursPerDay = 0;
                        break;
                }

                empWagePerDay = empWorkingHoursPerDay * wagesPerHr;
                Console.WriteLine("Employee Wage of the day : " + empWagePerDay);
            }
            public void EmpWagePerMonth()
            {
                int empHrs = 0;
                int empWages = 0;
                int totalEmpWage = 0;
                for (int day = 0; day < totalWorkingDays; day++)
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case isPartTime:
                            empHrs = 4;
                            break;
                        case isPresent:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empWages = empHrs * wagesPerHr;
                    totalEmpWage += empWages;
                    Console.WriteLine("emp wage: " + empWages);
                }
                Console.WriteLine("Total Employee wage of month: " + totalEmpWage);
            }
            public void EmpWageinCondition()
            {
                int emphrs = 0;
                int totalEmphrs = 0;
                int totalWorkingDays = 0;

                while (totalEmphrs <= maxHrsMonth && totalWorkingDays < numberOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case isPartTime:
                            emphrs = 4;
                            break;
                        case isPresent:
                            emphrs = 8;
                            break;
                        default:
                            emphrs = 0;
                            break;

                    }
                    totalEmphrs += emphrs;
                    Console.WriteLine("Days:" + totalWorkingDays + "emphrs:" + emphrs);
                }
                int totalEmpWage = totalEmphrs * wagesPerHr;
                Console.WriteLine("Total employee Wage in maximum conditionof 100hrs and 20 days :" + totalEmpWage);
            }
            public static int CalculationEmpWage()
            {
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;


                while (totalEmpHrs <= maxHrsMonth && totalWorkingDays < numberOfWorkingDays)
                {
                    totalWorkingDays++;

                    Random random = new Random();
                    int empcheck = random.Next(0, 3);
                    switch (empcheck)
                    {
                        case isPartTime:
                            empHrs = 4;
                            break;
                        case isPresent:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days :" + totalWorkingDays + "EmpHrs:" + empHrs);
                }
                int totalEmpWage = totalEmpHrs * wagesPerHr;
                Console.WriteLine("Total Employee wage:" + totalEmpWage);
                return totalEmpWage;
            }
        


    }
}

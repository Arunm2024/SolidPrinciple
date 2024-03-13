using static Solid.Employee;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee empFTE = new Employee() { EmployeeType = empType.FullTime.ToString(), TotalHourWorked = 10 };
            Employee empPTE = new Employee() { EmployeeType = empType.PartTime.ToString(), TotalHourWorked = 10 };
            Employee contratcor = new Employee() { EmployeeType = empType.Contractor.ToString(), TotalHourWorked = 10 };
            Employee Clevel = new Employee() { EmployeeType = empType.CLevel.ToString(), TotalHourWorked = 10 };
            IStockOptions employeeFinances = new EmployeeFinancesForClevel();
            var totalpay = employeeFinances.CalculateSalary(Clevel);
            var totalRewards = employeeFinances.CalculateRewards(Clevel);
            var totalstocks = employeeFinances.CalculateStockOptions(Clevel);
            Console.WriteLine("Employee earning and rewards:{0},{1},{2}", totalpay, totalRewards, totalstocks);
        }
    }
}

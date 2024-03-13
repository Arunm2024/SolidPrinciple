using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solid.Employee;

namespace Solid
{
    public interface IEmployeeRewards
    {
        double CalculateRewards(Employee emp);
    }
    public interface IEmployeeFinances: IEmployeeRewards
    {
        double CalculateSalary(Employee emp);
    }
    public interface IStockOptions : IEmployeeFinances
    {
        double CalculateStockOptions(Employee emp);
    }
    public class EmployeeRewards
    {
        public virtual double CalculateRewards(Employee emp)
        {
            return 10;
        }
    }
    public class EmployeeFinances
    {
        public virtual double CalculateSalary(Employee emp)
        {
            return 10;
        }
    }
    public class EmployeeFinancesForFTE: IEmployeeFinances
    {
        public  double CalculateSalary(Employee emp)
        {
            return emp.TotalHourWorked * 10;
        }
        public  double CalculateRewards(Employee emp)
        {
            return 10;
        }
    }
    public class EmployeeFinancesForPTE : IEmployeeFinances
    {
        public  double CalculateSalary(Employee emp)
        {
            return emp.TotalHourWorked * 5;
        }
        public  double CalculateRewards(Employee emp)
        {
            return 9;
        }
    }
    public class EmployeeFinancesForContractor : IEmployeeRewards
    {
        //public override double CalculateSalary(Employee emp)
        //{
        //    return emp.TotalHourWorked * 2;
        //}
        public  double CalculateRewards(Employee emp)
        {
            return 8;
        }
    }
    public class EmployeeFinancesForClevel: IStockOptions
    {
        public double CalculateSalary(Employee emp)
        {
            return 50;
        }
        public double CalculateRewards(Employee emp)
        {
            return 50;
        }
        public double CalculateStockOptions(Employee emp)
        {
            return 50;
        }
    }
}

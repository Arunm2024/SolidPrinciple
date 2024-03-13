using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Employee
    {
        public string EmployeeType {  get; set; }
        public double TotalHourWorked {  get; set; }
        public void Save()
        {
            try
            {

            }
            catch(Exception ex)
            {
                Logger logger= new Logger();
                logger.LogError(ex.Message);
            }

        }
     public enum empType
        {
            FullTime,
            PartTime,
            Contractor,
            CLevel
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace classlib.behavioral.strategy
{
    public class JuniorSalaryCalculatorStrategy : IStrategySalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports)
        {
            return developerReports.Where(developerReport => developerReport.Level == DeveloperLevel.Junior).Select(developerReport => developerReport.CalculateSalary()).Sum();
        }
    }
}
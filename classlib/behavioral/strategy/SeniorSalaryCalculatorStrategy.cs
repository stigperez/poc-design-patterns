using System.Collections.Generic;
using System.Linq;

namespace classlib.behavioral.strategy
{
    public class SeniorSalaryCalculatorStrategy : IStrategySalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports)
        {
            return developerReports.Where(developerReport => developerReport.Level == DeveloperLevel.Senior).Select(developerReport => developerReport.CalculateSalary() * 1.2).Sum();
        }
    }
}
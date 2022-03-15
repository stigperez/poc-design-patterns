using System.Collections.Generic;

namespace classlib.behavioral.strategy
{
    public interface IStrategySalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports);
    }
}
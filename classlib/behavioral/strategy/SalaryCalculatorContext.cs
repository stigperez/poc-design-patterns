using System.Collections.Generic;

namespace classlib.behavioral.strategy
{
    public class SalaryCalculatorContext
    {
        public IStrategySalaryCalculator SalaryCalculator { get; set; }

        public SalaryCalculatorContext(IStrategySalaryCalculator salaryCalculator)
        {
            SalaryCalculator = salaryCalculator;
        }
        
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports) => SalaryCalculator.CalculateTotalSalary(developerReports);
    }
}
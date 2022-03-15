using System.Collections.Generic;
using System.Text;

namespace classlib.behavioral.strategy
{
    /*
    * Strategy pattern isolates different algorithms in separate classes and uses a context class to hold the active strategy.
    * The context class only communicates with the strategy classes, it does not hold any implementation itself
    * Strategy: A class that implements one variation of a shared algorithm
    * Context: A class used to manage all strategy classes
    */
    public class StrategyOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var reports = new List<DeveloperReport>
            {
                new DeveloperReport { Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };

            // instantiating the context class with a strategy
            var calculatorContext = new SalaryCalculatorContext(new JuniorSalaryCalculatorStrategy());
            double totalJuniorSalary = calculatorContext.CalculateTotalSalary(reports);

            // changing the active strategy on the context class
            calculatorContext.SalaryCalculator = new SeniorSalaryCalculatorStrategy();
            double totalSeniorSalary = calculatorContext.CalculateTotalSalary(reports);
            stringBuilder.AppendLine($"Salary for junior developers: {totalJuniorSalary}");
            stringBuilder.AppendLine($"Salary for senior developers: {totalSeniorSalary}");
            stringBuilder.AppendLine($"Total salary: {totalJuniorSalary + totalSeniorSalary}");
            return stringBuilder.ToString();
        }
    }
}
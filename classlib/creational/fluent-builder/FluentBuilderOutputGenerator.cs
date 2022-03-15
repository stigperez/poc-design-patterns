namespace classlib.creational.fluentbuilder
{
    public class FluentBuilderOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var employee = new EmployeeBuilder()
                .SetName("John Doe")
                .SetPosition("CEO")
                .SetSalary(1)
                .Build();
            return employee.ToString();
        }
    }
}
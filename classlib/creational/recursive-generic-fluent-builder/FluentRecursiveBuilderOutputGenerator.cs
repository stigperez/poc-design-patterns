namespace classlib.creational.recursivegenericfluentbuilder
{
    public class FluentRecursiveBuilderOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var employee = new EmployeeBuilderDirector()
                .SetName("John Doe")
                .SetPosition("CEO")
                .SetSalary(1)
                .Build();
            return employee.ToString();
        }
    }
}
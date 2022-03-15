namespace classlib.creational.recursivegenericfluentbuilder
{
    // using the most "enriched" builder (EmployeeSalaryBuilder) since this class inherits members from all other builders
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {
        public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
    }
}
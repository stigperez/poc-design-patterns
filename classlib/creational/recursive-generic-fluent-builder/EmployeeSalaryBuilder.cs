namespace classlib.creational.recursivegenericfluentbuilder
{
    public class EmployeeSalaryBuilder<T>: EmployeePositionBuilder<EmployeeSalaryBuilder<T>> where T: EmployeeSalaryBuilder<T>
    {
        public T SetSalary(double salary)
        {
            _employee.Salary = salary;
            return (T)this;
        }
    }
}
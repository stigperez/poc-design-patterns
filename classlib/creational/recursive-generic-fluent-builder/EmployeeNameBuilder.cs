namespace classlib.creational.recursivegenericfluentbuilder
{
    public class EmployeeNameBuilder<T>: EmployeeRecursiveBuilder where T: EmployeeNameBuilder<T>
    {
        public T SetName(string name)
        {
            _employee.Name = name;
            return (T)this;
        }
    }
}
namespace classlib.creational.recursivegenericfluentbuilder
{
    public class EmployeePositionBuilder<T>: EmployeeNameBuilder<EmployeePositionBuilder<T>> where T: EmployeePositionBuilder<T>
    {
        public T SetPosition(string position)
        {
            _employee.Position = position;
            return (T)this;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace classlib.creational.fluentbuilder
{
    public class EmployeeBuilder
    {
        private Employee _employee = new Employee();

        public EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetPosition(string position)
        {
            _employee.Position = position;
            return this;
        }

        public EmployeeBuilder SetSalary(double salary)
        {
            _employee.Salary = salary;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace classlib.creational.recursivegenericfluentbuilder
{
    public abstract class EmployeeRecursiveBuilder
    {
        protected readonly Employee _employee;

        public EmployeeRecursiveBuilder()
        {
            _employee = new Employee();
        }

        public Employee Build() => _employee;
    }
}
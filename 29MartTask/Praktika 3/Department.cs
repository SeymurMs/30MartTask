using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_3
{
    class Department
    {
        public int EmployeeLimit { get; set; }
        private Employee[] _employees;
        public Department(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;
            _employees = new Employee[0];
        }

        
        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < EmployeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                return;

            }
            
            
        }
        public Employee GetEmployeeById(int? id)
        {
            if (id== null)
            {
                throw new NullReferenceException("Id Null ola bilmez!!!");
            }
            foreach (var employee in _employees)
            {
                if (employee.Id == id)
                    return employee;
            }
            return null;
            
        }
        public Employee [] GetEmployees()
        {
            return _employees;
        }
        
    }
}

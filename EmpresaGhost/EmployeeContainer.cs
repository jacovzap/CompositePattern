using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaGhost
{
    class EmployeeContainer: IEmployee
    {
        List<IEmployee> Employees = new List<IEmployee>();

        public void DisplayEmployee()
        {
            foreach(IEmployee Employee in Employees)
            {
                Employee.DisplayEmployee();
            }
        }

        public void AddEmployee(IEmployee Employee)
        {
            Employees.Add(Employee);
        }

        public void RemoveEmployee(IEmployee Employee)
        {
            Employees.Remove(Employee);
        }
    }
}

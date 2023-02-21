using System;
using System.Collections.Generic;
using System.Text;

namespace GitBasics
{
    class Employee
    {
        public int EmployeeId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public Company EmployeeCompany { get; set; }

        public int GetEmployeeId()
        {
            if (EmployeeCompany != null)
            {
                return EmployeeId;
            }
            return 0;
        }
    }
}

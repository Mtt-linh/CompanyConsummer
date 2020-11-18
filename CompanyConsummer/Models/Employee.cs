using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyConsummer.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int salary { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

    }
}
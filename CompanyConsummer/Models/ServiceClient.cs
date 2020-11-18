using CompanyConsummer.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace CompanyConsummer.Models
{
    public class ServiceClient
    {
      
        EmployeeServices.CompanyServiceClient client = new EmployeeServices.CompanyServiceClient();
        public List<Department> getAllDepartment()
        {
            var list = client.getDepartments().Tolist();
            var rt = new List<Department>();
            list.ForEach(b => rt.Add(new Department()
            {
                DepartmentID = b.DepartmentID,
                DepartmentName = b.DepartmentName,
            }
            ));
            return rt;
        }
        public List<Employee> GetEmployees()
        {
            var list = client.getEmployees().ToList();
            var rt = new List<Employee>();
            list.ForEach(b => rt.Add(new Employee()
            {
                EmployeeID = b.EmployeeID,
                EmployeeName = b.EmployeeName,
                salary = (int)b.Salary,
                DepartmentID = b.Department.DepartmentID,
            }
            ));
            return rt;
        }
        public bool CreateDepartment(Department newtDepartmen)
        {
            var department = new EmployeeServices.Department()
            {
                DepartmentID = newtDepartmen.DepartmentID,
                DepartmentName = newtDepartmen.DepartmentName,

            };
            return client.createDepartment(department);
        }
        public bool CreateDepartment(Employee newEmp)
        {
            var employee = new EmployeeServices.Employee()
            {
                EmployeeID = newEmp.EmployeeID,
                EmployeeName = newEmp.EmployeeName,
                Salary = newEmp.salary,
                DepartmentID = newEmp.Department.DepartmentID,

            };
            return client.createEmployee(employee);
        }
    }
}
using DemoApp.Models;
using DemoApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.Repository
{
    public class EmployeeRepository
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeRepository()
        {
            _employeeService = new EmployeeService();
        }

        public int CreateEmployee(Employee model)
        {
            return _employeeService.CreateEmployee(model);
        }
        public int UpdateEmployee(Employee model)
        {
            return _employeeService.UpdateEmployee(model);
        }

        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }
        public bool DeleteEmployee(int id)
        {
            return _employeeService.DeleteEmployee(id);
        }
    }
}
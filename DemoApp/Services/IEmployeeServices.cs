using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Services
{
    public interface IEmployeeService
    {
        int CreateEmployee(Employee model);
        Employee GetEmployee(int id);
        List<Employee> GetAllEmployees();
        int UpdateEmployee(Employee model);
        bool DeleteEmployee(int id);
    }
}

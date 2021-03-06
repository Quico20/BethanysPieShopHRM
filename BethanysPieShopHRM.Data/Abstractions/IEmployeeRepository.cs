using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Data.Abstractions
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        int Commit();
    }
}

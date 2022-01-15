using BethanysPieShopHRM.Data.Abstractions;
using BethanysPieShopHRM.Data.DataContext;
using BethanysPieShopHRM.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopHRM.Data.DataRepository.SqlRepository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        readonly AppDbContext dbContext;

        public SqlEmployeeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            dbContext.Add(employee);
            Commit();
            return employee;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = GetEmployeeById(employeeId);
            if (employee != null)
            {
                dbContext.Remove(employee);
            }
            Commit();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return dbContext.Employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return dbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);            
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employeefound = dbContext.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if(employeefound!=null)
            {
                var entity = dbContext.Attach(employee);
                entity.State = EntityState.Modified;
                Commit();
                return employee;
            }

            return null;
        }
    }
}

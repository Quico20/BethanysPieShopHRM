using BethanysPieShopHRM.DataAccess.Abstractions;
using BethanysPieShopHRM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.DataAccess.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        readonly HttpClient httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>(await httpClient.GetStreamAsync($"api/employee/{employeeId}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmploye(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}

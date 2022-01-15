using BethanysPieShopHRM.DataAccess.Abstractions;
using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.DataAccess.Services
{
    public class JobCategoryDataService : IJobCategoryDataService
    {
        readonly HttpClient httpClient;

        public JobCategoryDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<JobCategory>>(await httpClient.GetStreamAsync($"api/jobcategory"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await JsonSerializer.DeserializeAsync<JobCategory>(await httpClient.GetStreamAsync($"api/jobcategory/{jobCategoryId}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}

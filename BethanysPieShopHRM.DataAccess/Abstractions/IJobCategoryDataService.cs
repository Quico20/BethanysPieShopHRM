using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.DataAccess.Abstractions
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}

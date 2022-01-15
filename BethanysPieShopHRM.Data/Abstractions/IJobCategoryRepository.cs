using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Data.Abstractions
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}

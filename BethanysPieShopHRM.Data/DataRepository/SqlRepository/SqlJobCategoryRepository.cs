using BethanysPieShopHRM.Data.Abstractions;
using BethanysPieShopHRM.Data.DataContext;
using BethanysPieShopHRM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShopHRM.Data.DataRepository.SqlRepository
{
    public class SqlJobCategoryRepository : IJobCategoryRepository
    {
        readonly AppDbContext dbContext;

        public SqlJobCategoryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<JobCategory> GetAllJobCategories()
        {
            return dbContext.JobCategories;
        }

        public JobCategory GetJobCategoryById(int jobCategoryId)
        {
            return dbContext.JobCategories.FirstOrDefault(j => j.JobCategoryId == jobCategoryId);
        }
    }
}

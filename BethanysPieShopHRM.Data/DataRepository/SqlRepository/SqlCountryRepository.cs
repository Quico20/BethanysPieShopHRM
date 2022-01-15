using BethanysPieShopHRM.Data.Abstractions;
using BethanysPieShopHRM.Data.DataContext;
using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopHRM.Data.DataRepository.SqlRepository
{
    public class SqlCountryRepository : ICountryRepository
    {
        readonly AppDbContext dbContext;

        public SqlCountryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return dbContext.Countries;
        }

        public Country GetCountryById(int countryId)
        {
            return dbContext.Countries.FirstOrDefault(c => c.CountryId == countryId);
        }
    }
}

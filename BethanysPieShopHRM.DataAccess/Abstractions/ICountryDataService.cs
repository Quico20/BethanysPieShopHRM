using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.DataAccess.Abstractions
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}

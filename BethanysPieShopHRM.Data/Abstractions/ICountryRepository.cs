using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Data.Abstractions
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}

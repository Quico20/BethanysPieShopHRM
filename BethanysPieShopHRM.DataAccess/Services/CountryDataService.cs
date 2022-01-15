using BethanysPieShopHRM.DataAccess.Abstractions;
using BethanysPieShopHRM.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.DataAccess.Services
{
    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient httpClient;

        public CountryDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>(await httpClient.GetStreamAsync($"api/country"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await JsonSerializer.DeserializeAsync<Country>(await httpClient.GetStreamAsync($"api/country/{countryId}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}

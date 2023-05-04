using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace DataAccessLayer.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        public readonly DataContext weatherContext;

        public CountryRepository(DataContext weatherContext)
        {
            this.weatherContext = weatherContext;
        }

        public async Task AddCountryAsync(Country country)
        {
            await weatherContext.Countries.AddAsync(country);
            await weatherContext.SaveChangesAsync();
        }
    }
}

using DesafioAMcom.Application.Interfaces;
using DesafioAMcom.Domain;

namespace DesafioAMcom.Application.Services
{
    public class CountryService : ICountryService
    {
        private readonly JsonCountryRepository _repo;
        public CountryService(JsonCountryRepository repo) => _repo = repo;
        public IEnumerable<Country> GetCountries() => _repo.LoadCountries();
    }
}

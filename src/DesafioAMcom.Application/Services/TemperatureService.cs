using DesafioAMcom.Application.Interfaces;
using DesafioAMcom.Domain;
using DesafioAMcom.Infrastructure;

namespace DesafioAMcom.Application.Services
{
    public class TemperatureService : ITemperatureService
    {
        private readonly CacheTemperatureRepository _repo;
        public TemperatureService(CacheTemperatureRepository repo) => _repo = repo;
        public double Converter(Temperature temp) => _repo.ConvertAndCache(temp);
    }
}

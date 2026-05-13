using DesafioAMcom.Domain;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAMcom.Infrastructure
{
    public class CacheTemperatureRepository
    {
        private readonly IMemoryCache _cache;
        public CacheTemperatureRepository(IMemoryCache cache) => _cache = cache;

        public double ConvertAndCache(Temperature temp)
        {
            string key = $"{temp.Value}-{temp.Unit}";
            if (_cache.TryGetValue(key, out double cached)) return cached;

            double result = temp.Unit.ToLower() switch
            {
                "c" => (temp.Value * 9 / 5) + 32,
                "f" => (temp.Value - 32) * 5 / 9,
                _ => throw new ArgumentException("Unidade inválida")
            };

            _cache.Set(key, result, TimeSpan.FromMinutes(10));
            return result;
        }
    }
}

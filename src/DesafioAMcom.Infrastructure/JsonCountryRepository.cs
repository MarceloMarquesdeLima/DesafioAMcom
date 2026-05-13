using DesafioAMcom.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Text.Json;

namespace DesafioAMcom.Infrastructure
{
    public IEnumerable<Country> LoadCountries()
    {
        var json = File.ReadAllText("Resources/paises.json");
        return JsonSerializer.Deserialize<IEnumerable<Country>>(json)!;
    }
}

using DesafioAMcom.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAMcom.Application.Interfaces
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
    }
}

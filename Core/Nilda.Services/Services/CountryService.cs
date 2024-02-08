using Nilda.EntityFrameworkCore.Interfaces;
using Nilda.EntityFrameworkCore.Repositories;
using Nilda.Services.Dto;
using Nilda.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.Services.Services
{
    internal class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IEnumerable<CountryDto> GetCountries()
        {
            var countries = _countryRepository.GetCountries();
            return countries?.Select(s => new CountryDto() { Code = s.CountryCode, Name = s.Name });
        }
    }
}

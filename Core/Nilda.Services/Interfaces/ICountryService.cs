using Nilda.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.Services.Interfaces
{
    public interface ICountryService
    {
        IEnumerable<CountryDto> GetCountries();
    }
}

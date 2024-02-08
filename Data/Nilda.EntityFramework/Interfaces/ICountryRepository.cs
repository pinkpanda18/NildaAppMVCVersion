using Nilda.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Interfaces
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
    }
}

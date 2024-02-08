using Nilda.EntityFramework;
using Nilda.EntityFrameworkCore.Entities;
using Nilda.EntityFrameworkCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Repositories
{ 
    internal class CountryRepository<TDbContext> : ICountryRepository
        where TDbContext : AppDbContext
    {
        protected readonly TDbContext _dbContext;
        public CountryRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Country> GetCountries()
        {
            var countries =  _dbContext.Countries.OrderBy(o => o.Name);

            return countries.AsEnumerable();
        }
    }
}

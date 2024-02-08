using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Entities
{
    public class City
    {
        public int CityId { get; set; }

        [Required, MaxLength(60)]
        public string Name { get; set; }
        public int CountryRegionId { get; set; }
        public CountryRegion CountryRegion { get; set; }

        public ICollection<DistrictOrTown> DistrictOrTowns { get; set; }
    }
}

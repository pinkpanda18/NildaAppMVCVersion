using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Entities
{
    public class CountryRegion
    {
        public int CountryRegionId { get; set; }

        [Required, MaxLength(60)]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; } 
        public ICollection<City> Cities { get; set; }
    }
}

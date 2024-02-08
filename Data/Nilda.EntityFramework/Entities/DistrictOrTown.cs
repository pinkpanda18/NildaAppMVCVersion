using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Entities
{
    public class DistrictOrTown
    {
        public int DistrictOrTownId { get; set; }

        [Required, MaxLength(60)]
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Barangay> Barangays { get; set; }
    }
}

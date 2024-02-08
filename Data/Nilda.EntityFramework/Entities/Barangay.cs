using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Entities
{
    public class Barangay
    {
        public int BarangayId { get; set; }

        [Required, MaxLength(60)]
        public string Name { get; set; }
        public int DistrictOrTownId { get; set; }
        public DistrictOrTown DistrictOrTown { get; set; }
    }
}

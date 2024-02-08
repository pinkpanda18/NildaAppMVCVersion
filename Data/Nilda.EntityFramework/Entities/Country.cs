using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nilda.EntityFrameworkCore.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        
        [Required, MaxLength(60)]
        public string Name { get; set; }

        [Required, MaxLength(5)]
        public string CountryCode { get; set; }
        public bool isActive { get; set; }
        public bool isDefault { get; set; }
        public ICollection<CountryRegion> Regions { get; set; }
         
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlaceManager.Data.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        public IEnumerable<OpeningHour> OpeningHours { get; set; }
    }
}

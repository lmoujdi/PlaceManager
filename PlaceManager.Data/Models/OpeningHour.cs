

using System.ComponentModel.DataAnnotations;

namespace PlaceManager.Data.Models
{
    public class OpeningHour
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Day { get; set; }

        [Required]
        public OpeningHourType openingHourType { get; set; }

        [Required]
        [StringLength(5)]
        public string Start { get; set; }

        [Required]
        [StringLength(5)]
        public string  End { get; set; }

        public int PlaceId { get; set; }

    }
    public enum OpeningHourType
    {
        Open,
        Close
    }
}

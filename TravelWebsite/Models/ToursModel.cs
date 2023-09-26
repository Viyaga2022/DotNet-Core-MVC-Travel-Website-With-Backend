using System.ComponentModel.DataAnnotations;

namespace TravelWebsite.Models
{
    public class ToursModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string TourName { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string TourImage { get; set; }
    }
}

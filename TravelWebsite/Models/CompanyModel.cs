using System.ComponentModel.DataAnnotations;

namespace TravelWebsite.Models
{
    public class CompanyModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string WhyChooseUs { get; set; }

        [Required]
        public string CompanyPhoneNumber { get; set; }

        [Required]
        public string CompanyEmail { get; set; }

        [Required]
        public string CompanyFullAddress { get; set; }

        [Required]
        public string CompanyShortAddress { get; set; }

        [Required]
        public string GoogleMapUrl { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace TravelWebsite.Models
{
    public class ContactModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required, Display(Name="Phone Number")]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }
    }
}

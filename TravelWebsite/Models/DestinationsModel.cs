using System.ComponentModel.DataAnnotations;

namespace TravelWebsite.Models
{
    public class DestinationsModel
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name="Destination Name")]
        public string DestinationName { get; set; }

        [Required, Display(Name ="Destination Image")]
        public string DestinationImage { get; set; }
    }
}

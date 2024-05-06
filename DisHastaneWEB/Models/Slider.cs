using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisHastaneWEB.Models
{
    public class Slider
    {
        [Key] public int Id { get; set; }
        public string SliderName { get; set; } = string.Empty;
        public string UpTitle { get; set; } = string.Empty;
        public string DowmTitle { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
    }
}

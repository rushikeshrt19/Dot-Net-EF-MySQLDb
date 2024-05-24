using System.ComponentModel.DataAnnotations;

namespace Dot_Net_EF_MySqlDb.API.Models.Domain
{
    public class Region
    {
        [Required]
        public string Id { get; set; }

        [MaxLength(4)]
        public string Code { get; set; }

        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}

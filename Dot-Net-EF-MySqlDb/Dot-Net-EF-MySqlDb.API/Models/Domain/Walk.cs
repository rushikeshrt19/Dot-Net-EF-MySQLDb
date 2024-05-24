using System.ComponentModel.DataAnnotations;

namespace Dot_Net_EF_MySqlDb.API.Models.Domain
{
    public class Walk
    {
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public string DifficultyId { get; set; }
        public string RegionId { get; set; }

        // Navigation Property :Walk class Represents One to One Relation between Region and Difficulty Class
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }

    }
}

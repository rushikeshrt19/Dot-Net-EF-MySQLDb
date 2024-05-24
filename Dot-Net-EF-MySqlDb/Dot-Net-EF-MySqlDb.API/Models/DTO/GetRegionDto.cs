using System.ComponentModel.DataAnnotations;

namespace Dot_Net_EF_MySqlDb.API.Models.DTO
{
    public class GetRegionDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}

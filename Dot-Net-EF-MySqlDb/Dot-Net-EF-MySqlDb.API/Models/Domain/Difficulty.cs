using System.ComponentModel.DataAnnotations;

namespace Dot_Net_EF_MySqlDb.API.Models.Domain
{
    public class Difficulty
    {
        [Required]
        public string Id { get; set; }

        public string Name { get; set; }

    }
}

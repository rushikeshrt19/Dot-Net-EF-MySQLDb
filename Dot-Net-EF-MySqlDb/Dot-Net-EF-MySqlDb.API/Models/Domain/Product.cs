using System.ComponentModel.DataAnnotations;

namespace Dot_Net_EF_MySqlDb.API.Models.Domain
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

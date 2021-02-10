using System.ComponentModel.DataAnnotations;

namespace FoodPal.Providers.DomainModel
{
    public class Provider : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(300)]
        public string Location { get; set; }
        public Catalogue Catalogue { get; set; }
        public ProviderCategory Category { get; set; }
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }
    }
}

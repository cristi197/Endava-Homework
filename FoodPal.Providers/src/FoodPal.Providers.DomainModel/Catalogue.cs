using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodPal.Providers.DomainModel
{
    public class Catalogue : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        public List<CatalogueItem> Items { get; set; }
        public Provider Provider { get; set; }
        public int ProviderId { get; set; }
    }
}

using System;

namespace FoodPal.Providers.DomainModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

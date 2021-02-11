using FoodPal.Providers.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public interface ICatalogueItemRepository:IRepository<CatalogueItem>
    {
        Task<IEnumerable<CatalogueItem>> GetAllCatalogueItemByProviderIdAsync(int providerId);

        Task<CatalogueItem> GetCatalogueItemByCatalogueItemId(int catalogueItemId);

    }
}

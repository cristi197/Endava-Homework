using FoodPal.Providers.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class CatalogueItemRepository : Repository<CatalogueItem>, ICatalogueItemRepository
    {
        public CatalogueItemRepository(ProvidersContext providersContext) : base(providersContext)
        {

        }
        public async Task<IEnumerable<CatalogueItem>> GetAllCatalogueItemByProviderIdAsync(int providerId)
        {
            return await _providerContext.CatalogueItems
                .Include(ci => ci.Category)
                .Include(ci => ci.Catalogue)
                .ThenInclude(c => c.Provider)
                .ThenInclude(p=>p.Id)
                .Where(p=>p.Id == providerId)
                .ToListAsync();
        }

        public async Task<CatalogueItem> GetCatalogueItemByCatalogueItemId(int catalogueItemId)
        {
            return await _providerContext.CatalogueItems
                .Include(ci => ci.Category)
                .Include(ci => ci.Catalogue)
                .ThenInclude(c => c.Provider)
                .SingleOrDefaultAsync(ci=>ci.Id == catalogueItemId);
        }
    }
}

using FoodPal.Providers.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class ProviderRepository : Repository<Provider>,IProviderRepository
    {
        public ProviderRepository(ProvidersContext providersContext): base(providersContext)
        {

        }

        public async Task<IEnumerable<Provider>> GetAllWithCatalogueItemsAsync()
        {
            return await _providerContext.Providers
                .Include(p => p.Category)
                .Include(p => p.Catalogue)
                .ThenInclude(c => c.Items)
                .ThenInclude(i => i.Category)
                .ToListAsync();
        }

        public async Task<Provider> GetWithCatalogueItemsByIdAsync(int providerId)
        {
            return await _providerContext.Providers
                .Include(p => p.Category)
                .Include(p => p.Catalogue)
                .ThenInclude(c => c.Items)
                .ThenInclude(i => i.Category)
                .SingleOrDefaultAsync(x=>x.Id == providerId);
        }
    }
}

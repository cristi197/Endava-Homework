using FoodPal.Providers.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly ProvidersContext _providerContext;

        public Repository(ProvidersContext providersContext)
        {
            _providerContext = providersContext ?? throw new ArgumentNullException(nameof(providersContext));
        }
        public async Task AddAsync(T entity)
        {
            await _providerContext.Set<T>().AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _providerContext.Set<T>().ToListAsync();
        }

        public void Remove(T entity)
        {
            _providerContext.Set<T>().Remove(entity);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _providerContext.Set<T>().SingleOrDefaultAsync(expression);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Application.Common.Persistence
{
    public interface IBaseRepository<TId,T> where T : class
    {
        Task<T> GetByIdAsync(TId id, CancellationToken cancellationToken);
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
        Task RemoveAsync(T entity, CancellationToken cancellationToken);
        Task RemoveRangeAsync(List<T> entities, CancellationToken cancellationToken);
    }
}

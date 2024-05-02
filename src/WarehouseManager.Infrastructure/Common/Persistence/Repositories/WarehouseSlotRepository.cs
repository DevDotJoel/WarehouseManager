using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Application.Common.Persistence;
using WarehouseManager.Domain.WarehouseSlots;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Repositories
{
    public class WarehouseSlotRepository : IWarehouseSlotRepository
    {
        private readonly WarehouseManagerContext _dbContext;
        public WarehouseSlotRepository(WarehouseManagerContext dbContext)
        {

            _dbContext = dbContext;

        }
        public async Task AddAsync(WarehouseSlot entity, CancellationToken cancellationToken)
        {
           await _dbContext.AddAsync(entity, cancellationToken);
           await _dbContext.SaveChangesAsync();
        }

        public Task<WarehouseSlot> GetByIdAsync(WarehouseSlotId id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(WarehouseSlot entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(List<WarehouseSlot> entities, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(WarehouseSlot entity, CancellationToken cancellationToken)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

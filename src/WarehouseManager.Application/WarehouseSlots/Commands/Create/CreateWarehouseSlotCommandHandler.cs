using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Application.Common.Persistence;
using WarehouseManager.Domain.Products.ValueObjects;
using WarehouseManager.Domain.WarehouseSlots;

namespace WarehouseManager.Application.WarehouseSlots.Commands.Create
{
    public class CreateWarehouseSlotCommandHandler : IRequestHandler<CreateWarehouseSlotCommand, ErrorOr<WarehouseSlot>>
    {
        private readonly IWarehouseSlotRepository _warehouseSlotRepository;
        public CreateWarehouseSlotCommandHandler(IWarehouseSlotRepository warehouseSlotRepository)
        {
            _warehouseSlotRepository = warehouseSlotRepository;
            
        }
        public async Task<ErrorOr<WarehouseSlot>> Handle(CreateWarehouseSlotCommand request, CancellationToken cancellationToken)
        {
            var warehouseSlot = WarehouseSlot.Create(request.Name, request.ProductIds.ConvertAll(ProductId.Create));
            await _warehouseSlotRepository.AddAsync(warehouseSlot, cancellationToken);
            return warehouseSlot;
        }
    }
}

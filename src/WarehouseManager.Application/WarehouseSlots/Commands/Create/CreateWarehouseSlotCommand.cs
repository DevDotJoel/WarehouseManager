using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.WarehouseSlots;

namespace WarehouseManager.Application.WarehouseSlots.Commands.Create
{
    public record CreateWarehouseSlotCommand
     (
      string Name,
      List<Guid> ProductIds
     ):IRequest<ErrorOr<WarehouseSlot>>;
}

using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.Employees.ValueObjects
{
    public class EmployeeId:EntityId<Guid>
    {
        private EmployeeId(Guid value) :base(value)
        {
            
        }
        public static EmployeeId CreateUnique()
        {
            return new EmployeeId(Guid.NewGuid());
        }

        public static EmployeeId Create(Guid value)
        {
            return new EmployeeId(value);
        }
        private EmployeeId()
        {
                
        }
    }
}

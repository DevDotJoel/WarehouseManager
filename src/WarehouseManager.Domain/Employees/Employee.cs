using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Employees.ValueObjects;

namespace WarehouseManager.Domain.Employees
{
    public sealed class Employee:Entity<EmployeeId>
    {
        public string Number { get; private set; }
        public string Name { get; private set; }
        private Employee(EmployeeId id,string name,string number):base(id) 
        {
            Name = name;  
            Number = number;
        }
        public static Employee Create(string name,string number)
        {
            return new Employee(EmployeeId.CreateUnique(),name,number);
            
        }
        private Employee()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;

namespace PBJ.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public void Add(Employee b)
        {
            throw new NotImplementedException();
        }

        public void Edit(Employee b)
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> FindAll()
        {
            throw new NotImplementedException();
        }

        public Employee FindById(string Id)
        {
            // mock
            return new Employee {FirstName = "Test"};
        }
    }
}

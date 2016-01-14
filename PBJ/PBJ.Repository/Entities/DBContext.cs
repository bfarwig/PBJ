using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBJ.Repository.Entities
{
    public class Context : DbContext
    {
        public System.Data.Entity.DbSet<PBJ.Core.DTO.Employee> Employees { get; set; }
    }
}

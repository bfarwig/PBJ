using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;
using PBJ.Repository;

namespace PBJ.UnitTests.DependencyResolver
{
    public class TestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<EmployeeRepository>().As<IRepository<Employee>>();
        }
    }
}

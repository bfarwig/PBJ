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
    public class GlobalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //// Like structuremap we can load by assembly
            //var asm = Assembly.GetExecutingAssembly();
            //builder.RegisterAssemblyTypes(asm)
            //   .Where(t => t.Name.EndsWith("Repository"))
            //   .AsImplementedInterfaces();

            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<EmployeeRepository>().As<IRepository<Employee>>();

            // builder.RegisterType<IRepository<Employee>>();
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();


        }
    }
}

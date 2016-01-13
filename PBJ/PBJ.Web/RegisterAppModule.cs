﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;
using PBJ.Repository;
using Module = Autofac.Module;

namespace PBJ.Web
{
    // if this module gets too big and needs splitting do this instead.  http://devkimchi.com/631/dynamic-module-loading-with-autofac/
    public class RegisterAppModule: Module   
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
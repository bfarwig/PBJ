using System;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Owin;
using Owin;

namespace PBJ.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}

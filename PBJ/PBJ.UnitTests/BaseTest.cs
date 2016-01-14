using System.Web.Http;
using Autofac;
using NUnit.Framework;
using PBJ.Web;

namespace PBJ.UnitTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private IContainer _container;
        public IContainer Container
        {
            get { return _container; }
            set { _container = value; }
        }

        [SetUp]
        public void Init()
        {
        //    GlobalConfiguration.Configure(WebApiConfig.Register);
            Container = AutofacConfig.ConfigureContainer();
        }
    }
}

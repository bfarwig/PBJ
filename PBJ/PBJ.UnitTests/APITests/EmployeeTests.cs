using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using Autofac;
using NSubstitute;
using NUnit.Framework;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;
using PBJ.Web.Controllers.API;

namespace PBJ.UnitTests.APITests
{
    [TestFixture]
    public class ClientTests : BaseTest
    {

        private IClientRepository _clientMock;
        [TestFixtureSetUp]
        public void ClientSetup()
        {
            _clientMock = Substitute.For<IClientRepository>();
        }
      
        [Test]
        public void GetClient_ShouldReturnOneClient()
        {
            var controller = Container.Resolve<ClientsController>();
            var mockResult = Substitute.For<Client>();
            mockResult.Id = 1;

            _clientMock.Get(1).Returns(mockResult);

            var actionResult = controller.GetClient(1);
            Assert.IsInstanceOf<OkNegotiatedContentResult<Client>>(actionResult);
           //not sure how to do this assert...todo research
        }

    }
}

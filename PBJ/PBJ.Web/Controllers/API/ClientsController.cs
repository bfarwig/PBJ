using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;

namespace PBJ.Web.Controllers.API
{
    public class ClientsController : ApiController
    {
        private readonly IClientRepository _clientRepo;
        public ClientsController(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = _clientRepo.Get(id);
            return Ok(client);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBJ.Core.DTO;
using PBJ.Core.Interfaces;

namespace PBJ.Repository
{
    public class ClientRepository : IClientRepository, IDisposable
    {
        private DbContext _context;
        public ClientRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> Get()
        {
            throw new NotImplementedException();
        }

        public Client Get(int studentId)
        {
            // todo setup context
            return new Client() {Id = 1, Name = "test"};
        }

        public void Insert(Client student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int clientId)
        {
            throw new NotImplementedException();
        }

        public void Update(Client student)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

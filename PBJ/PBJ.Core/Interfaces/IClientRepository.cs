using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBJ.Core.DTO;

namespace PBJ.Core.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> Get();
        Client Get(int studentId);
        void Insert(Client student);
        void Delete(int clientId);
        void Update(Client student);
        void Save();
    }
}

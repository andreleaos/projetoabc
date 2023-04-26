using ConsoleAppExemplo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExemplo.Infrastructure.Repositories
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
        List<Cliente> GetAll();
        Cliente Get(int id);
    }
}

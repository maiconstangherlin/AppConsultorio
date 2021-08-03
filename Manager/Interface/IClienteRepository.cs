using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClienteAsync();

        Task<Cliente> GetClienteAsync(int id);
    }
}

using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IClienteManager
    {

        Task DeleteAsync(int id);
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteAsync(int id);
        Task<Cliente> InsertClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);

    }
}

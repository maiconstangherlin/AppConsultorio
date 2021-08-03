using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IClienteManager
    {

        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> GetClienteAsync(int id);

    }
}

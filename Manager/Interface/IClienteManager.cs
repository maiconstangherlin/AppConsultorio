using Core.Domain;
using Core.Shared.ModelViews;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IClienteManager
    {

        Task DeleteAsync(int id);
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteAsync(int id);
        Task<Cliente> InsertClienteAsync(NovoCliente novoCliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);

    }
}

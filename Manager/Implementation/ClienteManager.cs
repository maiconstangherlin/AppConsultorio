using Core.Domain;
using Manager.Interface;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clienteRepository.GetClienteAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await clienteRepository.GetClienteAsync(id);
        }
        
    }
}

using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using Manager.Interface;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IMapper mapper;

        public ClienteManager(IClienteRepository clienteRepository, IMapper mapper)
        {
            this.clienteRepository = clienteRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await clienteRepository.GetClienteAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await clienteRepository.DeleteAsync(id);
        }

        public async Task<Cliente> InsertClienteAsync(NovoCliente novoCliente)
        {
            var cliente = mapper.Map<Cliente>(novoCliente);
            return await clienteRepository.InsertClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(AlteraCliente alteraCliente)
        {
            var cliente = mapper.Map<Cliente>(alteraCliente);
            return await clienteRepository.UpdateClienteAsync(cliente);
        }
    }
}

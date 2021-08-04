using Core.Domain;
using Data.Context;
using Manager.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly ConsultorioContext context;

        public ClienteRepository(ConsultorioContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await GetClienteAsync(cliente.Id);
            if (clienteConsultado == null)
            {
                return null;
            }

            //Atribui ao 'clienteConsultado' todos os valores das prop. de 'cliente' que derem "match" com as prop. de 'clienteConsultado'
            context.Entry(clienteConsultado).CurrentValues.SetValues(cliente);            
            context.Clientes.Update(clienteConsultado);
            await context.SaveChangesAsync();

            return cliente;
        }

        public async Task DeleteAsync(int id)
        {
            var clienteConsultado = await GetClienteAsync(id);
            context.Clientes.Remove(clienteConsultado);
            await context.SaveChangesAsync();
        }
    }
}

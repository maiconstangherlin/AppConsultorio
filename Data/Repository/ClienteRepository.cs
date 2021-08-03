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

        public async Task<IEnumerable<Cliente>> GetClienteAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await context.Clientes.FindAsync(id);
        }

    }
}

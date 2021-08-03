using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ConsultorioContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        public ConsultorioContext(DbContextOptions options) : base(options)
        {
        }

    }
}

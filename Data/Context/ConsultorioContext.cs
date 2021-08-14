﻿using Core.Domain;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ConsultorioContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public ConsultorioContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
        }

    }
}

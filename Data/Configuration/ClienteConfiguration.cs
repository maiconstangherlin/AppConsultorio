using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            //Exemplos de configurações com o FluentAPI
            //builder.Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            //builder.Property(p => p.Sexo).HasDefaultValue("M").IsRequired();
            //builder.Property(p => p.Documento).HasColumnName("DocumentoIdentificador");

            //builder.HasIndex(p => new { p.Nome, p.Sexo });
        }
    }
}

using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.ClienteId);

            builder
                .HasOne(p => p.Cliente)
                .WithOne(p => p.Endereco)
                .HasForeignKey<Endereco>(p => p.ClienteId);
        }
    }
}

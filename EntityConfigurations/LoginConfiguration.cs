using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Fluent API

namespace VoeAirlines.EntityConfigurations;

public class LoginConfiguration : IEntityTypeConfiguration<Login>
{
    public void Configure(EntityTypeBuilder<Login> builder)
    {
        //throw new NotImplementedException();

        builder.ToTable("Logins");

        builder.HasKey(l => l.Id);

        builder.Property(l => l.Usuario)
               .IsRequired()
               .HasMaxLength(60);

        builder.Property(l => l.Senha)
                .IsRequired()
                .HasMaxLength(9);
    }
}




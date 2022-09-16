using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Configuration
{
    public class ServicesConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("Services");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder
                .Property(a => a.Service1)
                .HasColumnName("Service1")
                .HasColumnType("varchar(MAX)");

            builder
                .Property(a => a.Service2)
                .HasColumnName("Service2")
                .HasColumnType("varchar(MAX)");

            builder
                .Property(a => a.Service3)
                .HasColumnName("Service3")
                .HasColumnType("varhcar(MAX)");

            builder
                .Property(a => a.Service4)
                .HasColumnName("Service4")
                .HasColumnType("varchar(MAX)");

            builder
                .Property(a => a.Service5)
                .HasColumnName("Service5")
                .HasColumnType("varchar(MAX)");

            builder
                .Ignore("ServiceFull");
        }
    }
}

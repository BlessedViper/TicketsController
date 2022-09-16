using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Configuration
{
    public class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.ToTable("History");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");
            builder
                .Property(a => a.DataImportacao)
                .HasColumnName("DataImportacao")
                .HasColumnType("DateTime")
                .IsRequired();
            builder
                .Property(a => a.QuantidadeImportada)
                .HasColumnName("QuantidadeImportada")
                .HasColumnType("BIGINT");
        }
    }
}

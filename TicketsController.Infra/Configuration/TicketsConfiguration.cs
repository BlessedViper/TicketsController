using Microsoft.EntityFrameworkCore;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Configuration
{
    public class TicketsConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");

            builder.Property(a => a.Id)
                .HasColumnName("Id");

            builder.Property(a => a.Categoria)
                .HasColumnName("Categoria")
                .HasColumnType("varchar(MAX)");

            builder.Property(a => a.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("DateTime");

            builder.Property(a => a.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("varchar(MAX)");

            builder.Property(a => a.Status)
                .HasColumnName("Status")
                .HasColumnType("varchar(MAX)");

            builder.Property(a => a.UltimaAcao)
                .HasColumnName("UltimaAcao")
                .HasColumnType("DateTime");

            builder.Property(a => a.TimeAtendimento)
                .HasColumnName("TimeAtendimento")
                .HasColumnType("varchar(max)");

            builder.Property(a => a.NumAcoes)
                .HasColumnName("NumeroAcoes")
                .HasColumnType("int");

            builder.Property(a => a.IdService)
                .HasColumnName("IdService")
                .HasColumnType("int");

            builder
                .HasOne(t => t.Service)
                .WithMany(s => s.Ticket)
                .HasForeignKey(t => t.IdService);

            builder.Ignore("ServiceFull");
            builder.Ignore("Actions");

        }
    }
}

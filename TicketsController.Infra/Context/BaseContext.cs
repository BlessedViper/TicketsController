using Microsoft.EntityFrameworkCore;
using System.Linq;
using TicketsController.Domain.Entities;
using TicketsController.Infra.Configuration;

namespace TicketsController.Infra
{
    public class BaseContext : DbContext
    {

        private readonly string _connect = @"Server=.\sql2017dev;Database=TicketsController;User Id=sa;Password=inside@1";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies().UseSqlServer(_connect);
        }

        public DbSet<Services> Services { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<History> History { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ServicesConfiguration());
            modelBuilder.ApplyConfiguration(new TicketsConfiguration());
        }
        public void DeatchAllEntities()
        {
            var changedEntrieCopy = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();
            foreach (var entry in changedEntrieCopy)
                entry.State = EntityState.Detached;
        }
    }
}

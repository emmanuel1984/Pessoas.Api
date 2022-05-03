using Microsoft.EntityFrameworkCore;
using Pessoas.Api.Models;

namespace Pessoas.Api.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            //Database.EnsureCreated();
        }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>().HasKey(p => p.Id);
            builder.Entity<Pessoa>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pessoa>().Property(p => p.Nome).IsRequired().HasMaxLength(200);
            builder.Entity<Pessoa>().Property(p => p.CPF).IsRequired().HasMaxLength(11);
            builder.Entity<Pessoa>().Property(p => p.DataNascimento).IsRequired();
            builder.Entity<Pessoa>().Property(p => p.StatusPessoa).IsRequired();
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain.Entities;
using SistemaFinanceiro.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Data.Context
{
    public class EfDbContext : IdentityDbContext<Usuario>
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        { }
        public DbSet<Despesas> Despesas { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Recorrencia> Recorrencia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Despesas>(new DespesasMap().Configure);
            modelBuilder.Entity<Recorrencia>(new RecorrenciaMap().Configure);
            modelBuilder.Entity<Receitas>(new ReceitasMap().Configure);

        }
    }
}

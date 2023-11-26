using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Data.Mapping
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(prop => prop.CreatedAt)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnType("datetime");

            ConfigureEntity(builder);
        }

        public abstract void ConfigureEntity(EntityTypeBuilder<T> builder);


    }
}

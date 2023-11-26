using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaFinanceiro.;
using SistemaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Data.Mapping
{
    public class DespesasMap : BaseMap<Despesas>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Despesas> builder)
        {
            builder.ToTable("DESPESAS");
        }
    }
}

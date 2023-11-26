using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Data.Mapping
{
    public class ReceitasMap : BaseMap<Receitas>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Receitas> builder)
        {
            builder.ToTable("DESPESAS");
        }
    }
}


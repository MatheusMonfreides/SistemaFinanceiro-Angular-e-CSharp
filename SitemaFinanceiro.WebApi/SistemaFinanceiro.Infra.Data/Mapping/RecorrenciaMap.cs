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
    public class RecorrenciaMap : BaseMap<Recorrencia>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Recorrencia> builder)
        {
            builder.ToTable("USUARIO");
        }
    }
}

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
    public class UsuarioMap : BaseMap<Usuario>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");
        }
    }
}

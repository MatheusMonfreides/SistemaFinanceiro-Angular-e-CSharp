using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities.Enums
{
    public enum StatusUsuarioEnum
    {
        [Description("Inativo")]
        Inativo = 0,
        [Description("Ativo")]
        Ativo = 1
    }
}

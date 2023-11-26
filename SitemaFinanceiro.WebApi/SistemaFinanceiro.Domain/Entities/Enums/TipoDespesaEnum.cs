using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities.Enums
{
    public enum TipoDespesaEnum
    {
        [Description("Fixa")]
        Fixa = 0,
        [Description("Extra")]
        Extra = 1
    }
}

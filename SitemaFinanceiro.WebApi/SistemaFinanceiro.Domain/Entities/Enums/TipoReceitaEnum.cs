using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities.Enums
{
    public enum TipoReceitaEnum
    {
        [Description("Recorrente Fixa")]
        RecorrenteFixa = 0,

        [Description("Recorrente Limitada")]
        RecorrenteLimitada = 1, 

        [Description("Casual")]
        Casual = 2,  

        [Description("Extra")]
        Extra = 3,
    }
}

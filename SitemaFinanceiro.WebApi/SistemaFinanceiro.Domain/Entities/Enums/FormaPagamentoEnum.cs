using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities.Enums
{
    public enum FormaPagamentoEnum
    {
        [Description("Cartão")]
        Cartao = 0,
        [Description("Dinheiro")]
        Dinheiro = 1
    }
}

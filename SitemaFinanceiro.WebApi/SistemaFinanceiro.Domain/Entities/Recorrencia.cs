using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities
{
    public class Recorrencia : BaseEntity
    {
        public decimal REC_GASTODESPESA { get; set; }
        public decimal REC_VALOR { get; set; }
        public DateTime REC_DATA { get; set; }
    }
}

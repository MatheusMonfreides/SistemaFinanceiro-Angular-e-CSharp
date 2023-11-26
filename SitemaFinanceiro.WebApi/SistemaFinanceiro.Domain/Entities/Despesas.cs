using SistemaFinanceiro.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities
{
    public class Despesas : BaseEntity
    {
        public string DES_NOME {  get; set; }
        public decimal DES_VALOR { get; set; }
        public string DES_TAGS { get; set; }
        public FormaPagamentoEnum DES_FORMAPAGAMENTO { get; set; }
        public DateTime DES_DTDESPESA { get; set; }
        public TipoDespesaEnum DES_TIPODESPESA { get; set; }
        public bool DES_RECORRENCIA { get; set; }
        public DateTime DES_INICIORECORRENCIA { get; set; }
        public DateTime DES_FIMRECORRENCIA { get; set; }
       
        [ForeignKey("Usuario")]
        public Guid REC_IDUSUARIO { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

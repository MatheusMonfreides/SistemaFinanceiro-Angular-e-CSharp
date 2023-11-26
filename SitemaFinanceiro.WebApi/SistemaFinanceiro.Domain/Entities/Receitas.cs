using SistemaFinanceiro.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities
{
    public class Receitas : BaseEntity
    {
        public string REC_NOME { get; set; }
        public decimal REC_VALOR { get; set; }
        public DateTime REC_DTRECEBIMENTO { get; set; }
        public bool REC_RECORRENCIA { get; set; }
        public DateTime? REC_DTINICIORECO { get; set; }
        public DateTime? REC_DTFIMRECO { get; set; }
        public TipoReceitaEnum REC_TIPORECEITA { get; set; }
        public string REC_OBSERVACAO { get; set; }

        [ForeignKey("Usuario")]
        public Guid REC_IDUSUARIO { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

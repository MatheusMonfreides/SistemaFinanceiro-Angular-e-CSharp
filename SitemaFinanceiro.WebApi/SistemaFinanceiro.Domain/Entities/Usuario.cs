using Microsoft.AspNetCore.Identity;
using SistemaFinanceiro.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities
{
    public class Usuario : IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
        public StatusUsuarioEnum Status { get; set; } = StatusUsuarioEnum.Ativo;
    }
}

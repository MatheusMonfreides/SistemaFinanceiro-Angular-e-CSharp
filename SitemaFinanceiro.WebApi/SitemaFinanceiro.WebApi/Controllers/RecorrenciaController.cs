using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaFinanceiro.Domain.Entities;
using SistemaFinanceiro.Domain.Interfaces;

namespace SitemaFinanceiro.WebApi.Controllers
{
    public class RecorrenciaController : Controller
    {
        private readonly IBaseRepository<Recorrencia> _repRecorrencia;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Usuario> _userManager;
        public RecorrenciaController(UserManager<Usuario> userManager, IBaseRepository<Recorrencia> repRecorrencia, IConfiguration configuration)
        {
            _userManager = userManager;
            _repRecorrencia = repRecorrencia;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            List<Recorrencia> listaDespesas = await _repRecorrencia.SelectAllAsync().ToListAsync();
            return Ok(listaDespesas);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaFinanceiro.Domain.Entities;
using SistemaFinanceiro.Domain.Interfaces;

namespace SitemaFinanceiro.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DespesasController : Controller
    {
        private readonly IBaseRepository<Despesas> _repDespesas;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Usuario> _userManager;

        public DespesasController(UserManager<Usuario> userManager, IBaseRepository<Despesas> repDespesas, IConfiguration configuration)
        {
            _userManager = userManager;
            _repDespesas = repDespesas;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            List<Despesas> listaDespesas = await _repDespesas.SelectAllAsync().ToListAsync();
            return Ok(listaDespesas);
        }
    }
}

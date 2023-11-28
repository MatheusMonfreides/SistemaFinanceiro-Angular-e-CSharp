using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaFinanceiro.Domain.Entities;
using SistemaFinanceiro.Domain.Interfaces;

namespace SitemaFinanceiro.WebApi.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly IBaseRepository<Receitas> _repReceitas;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Usuario> _userManager;
        public ReceitasController(UserManager<Usuario> userManager, IBaseRepository<Receitas> repReceitas, IConfiguration configuration)
        {
            _userManager = userManager;
            _repReceitas = repReceitas;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            List<Receitas> listaDespesas = await _repReceitas.SelectAllAsync().ToListAsync();
            return Ok(listaDespesas);
        }
    }
}

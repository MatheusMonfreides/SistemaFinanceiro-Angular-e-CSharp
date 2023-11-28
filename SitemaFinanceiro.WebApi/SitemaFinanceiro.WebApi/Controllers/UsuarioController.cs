using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain.Entities;
using SistemaFinanceiro.Domain.Interfaces;

namespace SitemaFinanceiro.WebApi.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

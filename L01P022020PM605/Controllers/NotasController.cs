using L01P022020PM605.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace L01P022020PM605.Controllers
{
    public class NotasController : Controller
    {
        private readonly notasDbContext _notasDbContext;
        public NotasController(notasDbContext notasDbContext)
        {
            _notasDbContext = notasDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

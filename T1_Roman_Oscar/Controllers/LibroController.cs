using Microsoft.AspNetCore.Mvc;
using T1_Roman_Oscar.Datos;
using T1_Roman_Oscar.Models;

namespace T1_Roman_Oscar.Controllers
{
    public class LibroController : Controller
    {
        readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatoYMedio.Models;
using TuProyecto.Models;

namespace PlatoYMedio.Controllers
{
    public class ReservacionesController : Controller
    {
        private readonly PlatoYMedioDbContext _context;
        public ReservacionesController(PlatoYMedioDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var consulta = await _context.Reservaciones.ToListAsync();
            return View(consulta);
        }

        [HttpGet]
        public async Task<IActionResult> Detalle()
        {
            var consulta = await _context.Reservaciones.ToListAsync();
            return View(consulta);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Reservaciones reservacion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Reservaciones.Add(reservacion);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                else
                    return View(reservacion);
            }
            catch (Exception ex)
            {
                return View(reservacion);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Editar(int? id)
        {
            try
            {
                if (id == null)
                {
                    ViewData["TipoError"] = 2;
                    return View();
                }
                var reservacion = await _context.Reservaciones.FindAsync(id);
                if (reservacion == null)
                {
                    ViewData["TipoError"] = 1;
                    return View();
                }
                return View(reservacion);
            }
            catch (Exception ex)
            {
                ViewData["TipoError"] = 3;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Reservaciones reservacion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Reservaciones.Update(reservacion);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(reservacion);
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}

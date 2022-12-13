using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers;

public class AsignaturaController : Controller
{
    private readonly EscuelaContext _context;
    public AsignaturaController(EscuelaContext context)
    {
        _context=context;
    }
    public IActionResult Index()
    {
        return View(_context.Asignaturas.FirstOrDefault());
    }
    public IActionResult MultiAsignatura()
    {
        return View("MultiAsignatura", _context.Asignaturas.ToList());
    }
}

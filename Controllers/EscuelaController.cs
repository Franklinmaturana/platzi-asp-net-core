using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers;

public class EscuelaController : Controller
{
    private readonly EscuelaContext _context;
    public EscuelaController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        //var escuela = new Escuela();
        // escuela.Id = Guid.NewGuid().ToString();
        // escuela.Nombre = "Platzi";
        // escuela.Dirección="Calle 64 BB#106-51";
        // escuela.Pais="Colombia";
        // escuela.Ciudad="Bogota";
        // escuela.TipoEscuela=TiposEscuela.Secundaria;
        // escuela.AñoDeCreación = 2022;
        // ViewBag.CosaDinamica="La Monja";
        var escuela = _context.Escuelas.FirstOrDefault();
        return View(escuela);
    }

}

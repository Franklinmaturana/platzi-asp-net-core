using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers;

public class AlumnoController : Controller
{
    private readonly EscuelaContext _context;
    public AlumnoController(EscuelaContext context)
    {
        _context=context;
    }
    public IActionResult Index()
    {
        return View(_context.Alumnos.FirstOrDefault());
    }
    public IActionResult Multialumno()
    {
        var listaalumnos = _context.Alumnos;
        return View("Multialumno", listaalumnos.ToList());
    }

    private List<Alumno> GenerarAlumnosAlAzar()
    {
        string[] nombre1 = { "Alba", "Dilan", "Valentina", "Farid", "Donald", "Alvaro", "Nicolás" };
        string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Zuluaga", "Herrera" };
        string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

        var listaAlumnos = from n1 in nombre1
                           from n2 in nombre2
                           from a1 in apellido1
                           select new Alumno
                           {
                               Nombre = $"{n1} {n2} {a1}",
                               Id = Guid.NewGuid().ToString()
                           };

        return listaAlumnos.OrderBy((al) => al.Id).ToList();
    }
}

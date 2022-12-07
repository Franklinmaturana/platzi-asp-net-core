using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROGxefsi.Models;

namespace PROGxefsi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult HomeLogged()
    {
        var user = new UserProfileViewModel { Name = "María Pérez", Email = "maria@ejemplo.org", DonationsCount = 4 };
        return View("HomeLogged", user);
    }

    public IActionResult Catalogo()
    {
        var items = new List<OrganizationViewModel>
        {
            new OrganizationViewModel{ Id=1, Name="Fundación A", ShortDescription="Apoyo educativo", Location="Ciudad" },
            new OrganizationViewModel{ Id=2, Name="ONG B", ShortDescription="Salud comunitaria", Location="Provincia" },
            new OrganizationViewModel{ Id=3, Name="Colectivo C", ShortDescription="Alimentos", Location="Local" }
        };
        return View(items);
    }

    public IActionResult MapaOrganizaciones()
    {
        return View();
    }

    public IActionResult MapaOrganizacionesDetalle()
    {
        return View();
    }

    public IActionResult HacerDonacion()
    {
        var donation = new DonationViewModel{ Id=1, OrganizationName = "Fundación A", Amount = 50, Date = "2026-10-15" };
        return View(donation);
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult CrearUsuario()
    {
        return View();
    }

    public IActionResult CrearOrganizacion()
    {
        return View();
    }

    public IActionResult Perfil()
    {
        var profile = new UserProfileViewModel { Name = "María Pérez", Email = "maria@ejemplo.org", DonationsCount = 4 };
        return View(profile);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

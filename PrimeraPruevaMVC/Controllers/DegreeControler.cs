using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using PrimeraPruevaMVC.Entity;
using PrimeraPruevaMVC.Models;

namespace PrimeraPruevaMVC.Controllers;

public class DegreeController : Controller
{
    
    private readonly ILogger<DegreeController> _logger;
    private readonly ILogger<ApplicationDBContext> _context;

    public DegreeController(ApplicationDBContext context, ILogger<DegreeController> logger)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult DegreeAdd()
    {
        return View();
    }

    public IActionResult DegreeList()
    {

        _logger.LogInformation("Esto es un mensaje al cargar las carreras");

        DegreeModel carrera = new DegreeModel();
        carrera.Nombre ="Lic. en Administracion de Tecnologias de la Informacion";

        DegreeModel carrera2 = new DegreeModel();
        carrera2.Nombre ="Lic. en Mercadotecnia";

        DegreeModel carrera3 = new DegreeModel();
        carrera3.Nombre ="Lic. en Comercio Exterior";

        List<DegreeModel> List = new List<DegreeModel>();
        List.Add(carrera);
        List.Add(carrera2);
        List.Add(carrera3);

        return View(List);

    }


    [HttpPost]
    public IActionResult DegreeAdd(DegreeModel degree)
    {

        if (!ModelState.IsValid)
        {
            _logger.LogWarning(degree.Nombre);
            _logger.LogWarning("El modelo no es valido");
            return View();
        }
       
        _logger.LogInformation("El valor es valido");

        Degree degreeBD = new Degree();
        degreeBD.Id = new Guid();
        degreeBD.Name = degree.Nombre;
        degreeBD.CreationDate = DateTime.Today;

        _context.Degrees.Add(degreeDB);
        _context.SaveChanges();

        return Redirect("DegreeList");
    }

    public IActionResult DegreeEdit (Guid Id)
    {
        DegreeModel carrera = new DegreeModel();
        carrera.Id = Id;
        carrera.Nombre= "Carrera Cargada";
        return View(carrera);
    }

    [HttpPost]
    public IActionResult DegreeEdit(DegreeModel carrera)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("El modelo no es valido");
            carrera.Nombre= "Carrera no es valida";
            return View(carrera);
        }
        _logger.LogInformation("El modelo es valido");
        return Redirect("DegreeList");

    }

    public IActionResult DegreeShowToDelete(Guid Id)
    {
        DegreeModel carrera = new DegreeModel();
        carrera.Id = Id;
        carrera.Nombre= "Carrera para Borrar";
        return View(carrera);
    }

    [HttpPost]
    public ActionResult DegreeDeleted()
    {
        return Redirect("DegreeList");
    }
}

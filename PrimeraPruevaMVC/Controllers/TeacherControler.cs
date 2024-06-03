using Microsoft.AspNetCore.Mvc;
using PrimeraPruevaMVC.Models;

namespace PrimeraPruevaMVC.Controllers;
public class TeacherController : Controller
{
    public TeacherController()
    {
    }

    public IActionResult TeacherAdd()
    {
        return View();
    }


     public IActionResult TeacherList()
    {
        TeacherModel profesor = new TeacherModel();
        profesor.Nombre = "Ricardo Elizalde";
        profesor.Carrera = "Ing. en Sistemas Computacionales";

        TeacherModel profesor2 = new TeacherModel();
        profesor2.Nombre = "David Roman Flores Baez";
        profesor2.Carrera = "ing. en Sistemas Computacionales";

        List<TeacherModel> List = new List<TeacherModel>();
        List.Add(profesor);
        List.Add(profesor2);

        return View(List);
    }

    [HttpPost]
    public IActionResult TeacherAdd(TeacherModel teacher)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        return Redirect("TeacherList");
    }

    public IActionResult TeacherEdit()
    {
        return View();
    }

    public IActionResult TeacherShowToDelete()
    {
        return View();
    }

    public ActionResult TeacherDeleted()
    {
        return Redirect("TeacherList");
    }
}
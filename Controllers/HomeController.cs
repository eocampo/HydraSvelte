using Microsoft.AspNetCore.Mvc;
using HydraSvelte.Models;

namespace HydraSvelte.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        var model = new HomeIndexModel();
        model.Message = "Hello, Hydra!";
        return View(model);
    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorAdminPanel.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("/")]
    public IActionResult OnGet()
    {
        
        return View("~/Pages/_Host.cshtml");
    }
    
    [HttpPost]
    [Route("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.SetString("is_authed", "false");
        return RedirectToAction("OnGet");
    }
}
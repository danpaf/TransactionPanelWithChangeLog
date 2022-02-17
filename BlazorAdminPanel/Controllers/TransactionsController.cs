/*using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorAdminPanel.Controllers;

public class Transactions : Controller
{
    [HttpGet]
    [Route("/earnings")]
    public IActionResult OnGet()
    {
        
        return View("~/Pages/Earnings");
    }
    
    [HttpPost]
    [Route("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.SetString("is_authed", "false");
        return RedirectToAction("OnGet");
    }
}*/
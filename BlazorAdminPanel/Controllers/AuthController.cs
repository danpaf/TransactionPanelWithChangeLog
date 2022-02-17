using System.Linq;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.Extensions;
using BlazorAdminPanel.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorAdminPanel.Controllers;
[ApiController]
[Route("/auth")]

public class AuthController : Controller
{
    public class AuthCredentials
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
    
    private readonly ApplicationContext _db;
    public AuthController(ApplicationContext db)
    {
        _db = db;
    }
    [HttpGet]
    [Route("/auth")]
    public IActionResult OnGetAuth()
    {
        return View("~/Pages/Auth.cshtml");
    }

    [HttpPost]
    [Route("/auth")]
    public IActionResult OnPostAuth([FromBody] AuthCredentials credentials)
    {
        var user = _db.Users.FirstOrDefault(x => x.Email == credentials.Email);
        if (user == null)
            return new UnauthorizedResult();

        if (user.Password != credentials.Password.GetSha512())
            return new UnauthorizedResult();
        
        HttpContext.Session.SetString("is_authed", "true");
        HttpContext.Session.SetString("email", user.Email);
        return new OkResult();
    }
}

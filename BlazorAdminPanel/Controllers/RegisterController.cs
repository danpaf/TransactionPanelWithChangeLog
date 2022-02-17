using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using BlazorAdminPanel.Extensions;

namespace BlazorAdminPanel.Controllers;
[ApiController]
[Route("/register")]

public class RegisterController : Controller
{
    public class RegisterCredentials
    {
        [Required, MaxLength(256)]
        public string Password { get; init; }
        [Required]
        public int Age { get; init; }
        [Required]
        [EmailAddress(ErrorMessage = "Enter valid Email address")]
        public string Email { get; init; }
        
    }
    
    
    private readonly ApplicationContext _db;
    public RegisterController(ApplicationContext db)
    {
        _db = db;
    }
    [HttpGet]
    [Route("/register")]
    public IActionResult OnGetRegister()
    {
        return View("~/Pages/register.cshtml");
    }

    [HttpPost]
    [Route("/register")]
    public IActionResult OnPostRegister([FromBody] RegisterCredentials credentials)
    {
        
        if (String.IsNullOrEmpty(credentials.Password))
            return new BadRequestResult();

        if (!Utils.Utils.IsEmailValid(credentials.Email))
        {
            return BadRequest();
        }
        var dbUser = _db.Users.FirstOrDefault(x => x.Email == credentials.Email);
        if (dbUser != null)
        {
            return new BadRequestObjectResult(
            new {
                error="User with this email already exists"
            });
        }
        
        var user = new User
        {
            Uid = Guid.NewGuid(),
            Email = credentials.Email,
            Password = credentials.Password.GetSha512(),
            Age = credentials.Age,
            AddedDate = DateTime.UtcNow,
            StatusUid = new Guid("47d706e9-67ac-4e9c-9905-7439322731b6")
        };
        
        _db.Users.Add(user);
        _db.SaveChanges();
        
        return new OkResult();
        
    }
}
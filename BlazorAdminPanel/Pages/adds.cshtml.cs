using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Transactions;
using BlazorAdminPanel.Controllers;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.DataBase.Models;
using BlazorAdminPanel.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Transaction = System.Transactions.Transaction;
using Type = BlazorAdminPanel.DataBase.Models.Type;

namespace BlazorAdminPanel.Pages;

public class adds : PageModel
{

    private readonly ApplicationContext _context;
    
    [BindProperty]
    public BlazorAdminPanel.DataBase.Models.Transaction Transaction { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            _context.Transactions.Add(Transaction);
            await _context.SaveChangesAsync();
            return RedirectToPage("/");
        }

        return Page();
    }

    
}

public class TransactionController : Controller

{
    
    private readonly ApplicationContext _context;
    public TransactionController(ApplicationContext db)
    {
        _context = db;
    }
    public class AddsCredentials
    {
        public double Delta { get; init; }
        public Guid TypeUid { get; init; }
    }
    [HttpGet]
    [Route("/adds)")]
    public IActionResult OnGetSubmit()
    {
        return View("~/Pages/adds.cshtml");
    }
    [HttpPost]
    [Route("/adds")]
    public IActionResult OnSubmitAdds([FromForm] AddsCredentials credentials)
    {
        
        
        var transaction = new BlazorAdminPanel.DataBase.Models.Transaction()
        {
            Uid = Guid.NewGuid(),
            Delta = credentials.Delta,
            TypeUid = new Guid("f06b8508-190a-4e4b-b13b-1fccfe5cd610"),
            UserUid = new Guid(HttpContext.Session.GetString("userid")),
            AddedDate = DateTime.UtcNow,

        };
        
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        
        return new OkResult();
        
    }
    
}

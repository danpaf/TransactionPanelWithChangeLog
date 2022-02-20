/*using System;
using System.Threading.Tasks;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.Pages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorAdminPanel.Controllers;

public class Transactions : Controller
{
     private readonly ApplicationContext _context;
    
    [BindProperty]
    public BlazorAdminPanel.DataBase.Models.Transaction Transaction { get; set; }
    public adds(ApplicationContext db)
    {
        _context = db;
    }
   

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

        return BadRequest();
    }
    
    [HttpPost]
    [Route("/adds")]
    public IActionResult OnPostRegister([FromBody] adds credentials)
    {
        
        
        
        var transaction = new BlazorAdminPanel.DataBase.Models.Transaction()
        {
            Uid = Guid.NewGuid(),
            Delta = Transaction.Delta,
            TypeUid = Transaction.TypeUid,
            UserUid = Transaction.UserUid,
            AddedDate = DateTime.UtcNow,
          
        };
        
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        
        return new OkResult();
        
    }
}*/
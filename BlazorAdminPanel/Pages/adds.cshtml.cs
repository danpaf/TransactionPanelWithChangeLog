using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.DataBase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Transaction = System.Transactions.Transaction;

namespace BlazorAdminPanel.Pages;

public class adds : PageModel
{

    private readonly ApplicationContext _context;

    public class FinanceCredentials
    {
        public double Plus { get; init; }
        public double Minus { get; init; }
    }
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

        return Page();
    }

    [HttpGet]
    [Route("/adds")]
    public IActionResult OnGetFin()
    {
        return new OkResult();
    }
    [HttpPost]
    [Route("/adds")]
    public IActionResult OnPostAdds([FromBody] FinanceCredentials credentials)
    {
        var transaction = _context.Transactions.All(x => x.Plus == credentials.Plus);
        if (transaction == null)
            return new UnauthorizedResult();
        
        
        return new OkResult();
    }
}
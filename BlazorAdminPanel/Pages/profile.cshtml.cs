using System.Collections.Generic;
using System.Linq;
using BlazorAdminPanel.DataBase;
using BlazorAdminPanel.DataBase.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlazorAdminPanel.Pages;

public class profile : PageModel
{
    private readonly ApplicationContext _context;
    public List<Transaction> Transactions { get; set; }
    public profile(ApplicationContext db)
    {
        _context = db;
    }
    public void OnGet()
    {
        Transactions = _context.Transactions.AsNoTracking().ToList();
    }
}
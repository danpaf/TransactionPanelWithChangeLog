using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAdminPanel.DataBase.Models;

[Table("transactions")]
public class Transaction
{
    [Key] public Guid Uid { get; init; }
    public double Delta { get; set; }
    public DateTime AddedDate { get; set; }
    public Guid UserUid { get; set; }
    [ForeignKey("UserUid")] public User User { get; set; }
    public Guid TypeUid { get; set; }
    [ForeignKey("TypeUid")] public Type Type { get; set; }
    
    public double Plus { get; set; }
    public double Minus { get; set; }
}
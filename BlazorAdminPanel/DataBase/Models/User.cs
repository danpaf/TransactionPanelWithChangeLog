
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorAdminPanel.DataBase.Models;

[Table("users")]
public class User
{
    [Key] public Guid Uid { get; init; }
    public int Age { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTime AddedDate { get; set; }
    public Guid StatusUid { get; set; }
    [ForeignKey("StatusUid")] public Status Status { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAdminPanel.DataBase.Models;

[Table("statuses")]
public class Status
{
    [Key] 
    public Guid Uid { get; set; }
    public string Name { get; set; }
}
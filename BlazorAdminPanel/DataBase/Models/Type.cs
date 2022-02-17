using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAdminPanel.DataBase.Models;

[Table("types")]
public class Type
{
    [Key] public Guid Uid { get; set; }
    public string Name { get; set; }
}
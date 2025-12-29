using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class Taak
{
    public int Id { get; set; }
    public Evenement Evenement { get; set; }
    [MaxLength(50)]
    public string Naam { get; set; }
    [MaxLength(200)]
    public string Beschrijving { get; set; }
    public string Belangrijkheid { get; set; }
    public string Status { get; set; }
    public DateTime DeadLineDateTime { get; set; }

}

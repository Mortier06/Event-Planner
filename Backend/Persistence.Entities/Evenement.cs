using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class Evenement
{
    public int Id { get; set; }
    public Locatie Locatie { get; set; }
    [MaxLength(50)]
    public string Naam { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EindDateTime { get; set; }
}
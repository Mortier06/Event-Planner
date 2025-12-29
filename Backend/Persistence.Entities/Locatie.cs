using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class Locatie
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Naam { get; set; }
    [MaxLength(200)]
    public string Beschrijving { get; set; }
    public int GpsLat { get; set; }
    public int GpsLon { get; set; }
}

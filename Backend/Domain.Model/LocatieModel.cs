using System;

namespace Domain.Model;

public class LocatieModel
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
    public int GpsLat { get; set; }
    public int GpsLot { get; set; }
    
}

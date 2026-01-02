using System;

namespace API.Contracts.Locatie;

public class LocatieRequestContract
{
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
    public int GpsLat { get; set; }
    public int GpsLon { get; set; }
}

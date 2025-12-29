using System;

namespace Domain.Model;

public class EvenementModel
{
    public int Id { get; set; }
    public LocatieModel Locatie { get; set; }
    public string Naam { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EindDateTime { get; set; }
}

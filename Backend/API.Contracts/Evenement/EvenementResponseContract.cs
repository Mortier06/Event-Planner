using System;
using API.Contracts.Locatie;

namespace API.Contracts.Evenement;

public class EvenementResponseContract
{
    public int Id { get; set; }
    public LocatieResponseContract Locatie { get; set; }
    public string naam { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EindDateTime { get; set; }
}

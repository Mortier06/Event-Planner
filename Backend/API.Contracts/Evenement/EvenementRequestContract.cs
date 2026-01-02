using System;
using API.Contracts.Locatie;

namespace API.Contracts.Evenement;

public class EvenementRequestContract
{
    public int LocatieId { get; set; }
    public string naam { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EindDateTime { get; set; }

}

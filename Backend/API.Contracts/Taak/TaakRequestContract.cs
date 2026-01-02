using System;

namespace API.Contracts.Taak;

public class TaakRequestContract
{
    public int EvenementId { get; set; }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
    public string Belangrijkheid { get; set; }
}

using System;
using Domain.Model.Enums;

namespace Domain.Model;

public class TaakModel
{
    public int Id { get; set; }
    public EvenementModel Evenement { get; set; }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
    public Belangrijkheid Belangrijkheid { get; set; }
    public Status Status { get; set; }
    public DateTime DeadlineDateTime { get; set; }
}

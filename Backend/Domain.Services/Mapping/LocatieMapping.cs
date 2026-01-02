using System;
using API.Contracts.Locatie;
using Domain.Model;
using Persistence.Entities;

namespace Domain.Services.Mapping;

public static class LocatieMapping
{
    public static Locatie ToEntity(this LocatieRequestContract locatie)
    {
        return new Locatie
        {
            Naam = locatie.Naam,
            Beschrijving = locatie.Beschrijving,
            GpsLat = locatie.GpsLat,
            GpsLon = locatie.GpsLon
        };
    }
    public static LocatieResponseContract ToContract(this Locatie locatie)
    {
        return new LocatieResponseContract
        {
            Id = locatie.Id,
            Naam = locatie.Naam,
            Beschrijving = locatie.Beschrijving,
            GpsLat = locatie.GpsLat,
            GpsLon = locatie.GpsLon
        };
    }
}

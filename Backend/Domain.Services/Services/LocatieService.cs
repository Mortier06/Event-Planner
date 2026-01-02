using System;
using API.Contracts.Locatie;
using Percistence.Repositories;
using Domain.Services.Mapping;

namespace Domain.Services.Services;

public interface ILocatieService
{
    LocatieResponseContract CreateLocatie(LocatieRequestContract locatie);
}

public class LocatieService(ILocatieRepository repo) : ILocatieService
{
    public LocatieResponseContract CreateLocatie(LocatieRequestContract locatie)
    {
        var created = repo.CreateLocatie(locatie.ToEntity());
        return created.ToContract();
    }
}

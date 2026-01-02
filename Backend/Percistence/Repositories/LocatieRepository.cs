using System;
using Persistence.Entities;

namespace Percistence.Repositories;

public interface ILocatieRepository
{
    Locatie CreateLocatie(Locatie locatie);
    Locatie GetLocatie(int? id);
}

public class LocatieRepository(EventDBContext db, MongoDBContext dbLogs) : ILocatieRepository
{
    public Locatie CreateLocatie(Locatie locatie)
    {
        var created = db.Locaties.Add(locatie);
        db.SaveChanges();
        return locatie;
    }

    public Locatie GetLocatie(int? id)
    {
        return db.Locaties.Where(l => l.Id == id).Single() ?? throw new Exception("Niet gevonden");
    }
}

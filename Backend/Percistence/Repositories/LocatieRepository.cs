using System;
using Persistence.Entities;

namespace Percistence.Repositories;

public interface ILocatieRepository
{
    
}

public class LocatieRepository(EventDBContext db) : ILocatieRepository
{

}

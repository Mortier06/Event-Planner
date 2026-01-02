using System;
using System.ComponentModel.DataAnnotations.Schema;
using Persistence.Entities;

namespace Percistence.Repositories;

public interface ILoggingRepository
{
    public void Create(Audit log);

}

public class LoggingRepository(MongoDBContext context) : ILoggingRepository
{
    public void Create(Audit log)
    {
        context.Audits.Add(log);
        context.SaveChanges();
    }
}

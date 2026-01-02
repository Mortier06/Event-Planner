using System;
using API.Contracts.Logs;
using Domain.Model;
using Percistence.Repositories;
using Domain.Services.Mapping;


namespace Domain.Services.Services;

public interface ILoggingService
{
    void log(Object nieuwe, string action, int? id, bool isNew);
}

public class LoggingService(ILoggingRepository repo, ILocatieRepository LRepo) : ILoggingService
{
    public void log(object nieuwe, string action, int? id, bool isNew)
    {
        if (!isNew)
        {
            var old = LRepo.GetLocatie(id);
            LoggingModel model = new LoggingModel
            {
                Tijd = DateTime.UtcNow,
                Action = action,
                Oldvalue = old,
                NewValue = nieuwe
            };
            var entity = model.ToEntity();
            repo.Create(entity);
        }
        else
        {
            LoggingModel model = new LoggingModel
            {
                Tijd = DateTime.UtcNow,
                Action = action,
                NewValue = nieuwe
            };
            var entity = model.ToEntity();
            repo.Create(entity);
        }

    }
}

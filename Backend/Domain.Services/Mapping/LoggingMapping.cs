using System;
using Domain.Model;
using Persistence.Entities;

namespace Domain.Services.Mapping;

public static class LoggingMapping
{
    public static Audit ToEntity(this LoggingModel log)
    {
        return new Audit
        {
            Tijd = log.Tijd,
            Action = log.Action,
            NewValue = log.NewValue,
            Oldvalue = log.Oldvalue
        };
    }
}

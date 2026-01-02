using System;

namespace Domain.Model;

public class LoggingModel
{
    public int Id { get; set; }
    public DateTime Tijd { get; set; }
    public string Action { get; set; }
    public Object Oldvalue { get; set; }
    public Object NewValue { get; set; }
}

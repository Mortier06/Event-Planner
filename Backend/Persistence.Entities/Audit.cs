using System;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Entities;

public class Audit
{
    public ObjectId Id { get; set; }
    public DateTime Tijd { get; set; }
    public string Action { get; set; }
    [NotMapped]
    public Object Oldvalue { get; set; }
    [NotMapped]
    public Object NewValue { get; set; }

}

using System;

namespace ExampleFunctionApp.Models;

public class PersonWithId : IPersonWithId
{
    public bool HasBirthdayToday { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public Guid Id { get; set; }
    public DateTime DateOfId { get; set; }
}
using System;
using System.Collections.Generic;

namespace ExampleFunctionApp.Models;

public record AccessBook : IPersonWithAccess
{
    public PersonWithId BookOwner { get; set; }
    public IEnumerable<IPersonWithId> PersonsWithAccess
    {
        get;
        set;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public Guid Id { get; set; }
    public DateTime DateOfId { get; set; }
    public bool HasAccess { get; set; }
}
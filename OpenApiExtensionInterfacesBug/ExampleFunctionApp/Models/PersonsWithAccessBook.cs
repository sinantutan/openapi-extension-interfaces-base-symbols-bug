using System.Collections.Generic;

namespace ExampleFunctionApp.Models;

public record PersonsWithAccessBook
{
    public PersonWithAccess BookOwner { get; set; }
    public IEnumerable<IPersonWithAccess> PersonsWithAccess
    {
        get;
        set;
    }
}
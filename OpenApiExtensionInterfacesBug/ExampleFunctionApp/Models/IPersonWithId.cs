using System;

namespace ExampleFunctionApp.Models;

public interface IPersonWithId : IPersonWithoutId
{
    Guid Id { get; set; }
    DateTime DateOfId { get; set; }
}
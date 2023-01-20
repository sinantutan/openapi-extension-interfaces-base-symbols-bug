namespace ExampleFunctionApp.Models;

public interface IPersonWithAccess : IPersonWithId
{
    bool HasAccess { get; set; }
}
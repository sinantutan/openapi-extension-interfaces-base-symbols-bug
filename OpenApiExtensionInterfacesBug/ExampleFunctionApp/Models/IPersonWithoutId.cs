namespace ExampleFunctionApp.Models;

public interface IPersonWithoutId
{
    string Name { get; set; }
    string LastName { get; set; }
    string Age { get; set; }
}
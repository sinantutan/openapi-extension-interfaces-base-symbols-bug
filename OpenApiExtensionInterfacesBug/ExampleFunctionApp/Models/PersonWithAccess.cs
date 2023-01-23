using System;

namespace ExampleFunctionApp.Models
{
    public record PersonWithAccess : IPersonWithAccess
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public Guid Id { get; set; }
        public DateTime DateOfId { get; set; }
        public bool HasAccess { get; set; }
    }
}

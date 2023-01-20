using System.Collections.Generic;
using ExampleFunctionApp.Models;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Resolvers;
using Newtonsoft.Json.Serialization;

namespace ExampleFunctionApp;

public class OpenApiPersonWithAccessResponseExample : OpenApiExample<OpenApiPersonWithAccessResponseExample>
{
    public override IOpenApiExample<OpenApiPersonWithAccessResponseExample> Build(NamingStrategy namingStrategy = null)
    {
        var person = new AccessBook()
        {

        }
        
        this.Examples.Add(OpenApiExampleResolver.Resolve(nameof(AccessBook), appleSalad, namingStrategy));

        return this;
    }
}
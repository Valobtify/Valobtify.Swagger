using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Valobtify.Swagger;

/// <summary>
/// A schema filter for handling single value objects in Swagger documentation.
/// </summary>
public class SingleValueObjectSchemaFilter : ISchemaFilter
{
    private static readonly SingleValueObjectTemplate Template = SingleValueObjectTemplate.Create("")!;

    /// <summary>
    /// Applies custom schema modifications for single value objects in the Swagger documentation.
    /// </summary>
    /// <param name="schema">The OpenAPI schema to modify.</param>
    /// <param name="context">The context containing information about the schema being generated.</param>
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (!context.Type.IsSingleValueObject()) return;

        var valueType = context.Type.GetProperty(nameof(Template.Value))!.PropertyType;

        var jsonSchemaType = context.SchemaGenerator.GenerateSchema(valueType, context.SchemaRepository);

        schema.Type = jsonSchemaType.Type;
        schema.Format = jsonSchemaType.Format;

        schema.Properties.Clear();
    }
}
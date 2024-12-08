using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Valobtify.Swagger;

public class SingleValueObjectSchemaFilter : ISchemaFilter
{
    private static readonly SingleValueObjectTemplate Template = SingleValueObjectTemplate.Create("")!;

    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type.IsSingleValueObject())
        {
            var valueType = context.Type.GetProperty(nameof(Template.Value))!.PropertyType;

            var jsonSchemaType = context.SchemaGenerator.GenerateSchema(valueType, context.SchemaRepository);

            schema.Type = jsonSchemaType.Type;
            schema.Format = jsonSchemaType.Format;

            schema.Properties.Clear();
        }
    }
}
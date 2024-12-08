using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Valobtify.Swagger;

public static class Extensions
{
    public static SwaggerGenOptions AddValobtifySchemaFilters(this SwaggerGenOptions options)
    {
        options.SchemaFilter<SingleValueObjectSchemaFilter>();

        return options;
    }
}
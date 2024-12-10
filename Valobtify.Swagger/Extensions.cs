using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Valobtify.Swagger;

/// <summary>
/// Provides extension methods for configuring Swagger schema filters.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Adds schema filters for Valobtify types to the Swagger configuration.
    /// </summary>
    /// <param name="options">The SwaggerGenOptions to configure.</param>
    /// <returns>The configured SwaggerGenOptions.</returns>
    public static SwaggerGenOptions AddValobtifySchemaFilters(this SwaggerGenOptions options)
    {
        options.SchemaFilter<SingleValueObjectSchemaFilter>();

        return options;
    }
}
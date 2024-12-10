### Table of Contents

- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Integration with Swagger](#integration-with-swagger)
- [Related Packages](#related-packages)

---

### Overview

`Valobtify.Swagger` is an extension for integrating **Valobtify value objects** with **Swagger documentation** in ASP.NET Core. It automates the process of mapping value objects to Swagger schemas, ensuring your API documentation is accurate and reflective of your domain model.

---

### Installation

Install the `Valobtify.Swagger` package via NuGet:

```bash
dotnet add package Valobtify.Swagger
```

Ensure your project uses **Swashbuckle.AspNetCore** for Swagger support.

---

### Usage

1. **Add Swagger to Your Project**  
   First, configure Swagger in your ASP.NET Core project:

   ```csharp
   builder.Services.AddSwaggerGen();
   ```

2. **Add Valobtify Schema Filters**  
   Use the `AddValobtifySchemaFilters` extension method to enable value object schema support:

   ```csharp
   builder.Services.AddSwaggerGen(options =>
   {
       options.AddValobtifySchemaFilters();
   });
   ```

3. **Enable Middleware**  
   Add Swagger middleware to your application pipeline:

   ```csharp
   app.UseSwagger();
   app.UseSwaggerUI();
   ```

---

### Integration with Swagger

The `AddValobtifySchemaFilters` method ensures that all **Valobtify value objects** are correctly represented in your Swagger documentation. This means:
- **Automatic schema generation:** No manual configuration is needed.
- **Consistent API documentation:** Domain concepts using value objects are properly reflected.

---

### Related Packages

- [Valobtify](https://github.com/Valobtify/Valobtify): Core library for creating and using value objects in .NET.
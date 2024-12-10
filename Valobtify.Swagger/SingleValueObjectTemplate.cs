﻿using Resulver;

namespace Valobtify.Swagger;

internal sealed class SingleValueObjectTemplate :
    SingleValueObject<SingleValueObjectTemplate, string>,
    ICreatableValueObject<SingleValueObjectTemplate, string>
{
    private SingleValueObjectTemplate(string value) : base(value)
    {
    }

    public static Result<SingleValueObjectTemplate> Create(string value)
    {
        return new SingleValueObjectTemplate(value);
    }
}
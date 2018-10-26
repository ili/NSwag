﻿using NSwag.SwaggerGeneration;
using NSwag.SwaggerGeneration.AspNetCore;

namespace NSwag.AspNetCore
{
    /// <summary>Settings for the <see cref="AspNetCoreToSwaggerGenerator"/>.</summary>
    public class SwaggerDocumentSettings : AspNetCoreToSwaggerGeneratorSettings
    {
        /// <summary>Gets the document name (internal identifier, default: v1).</summary>
        public string DocumentName { get; set; } = "v1";

        /// <summary>Gets or sets the JSON Schema generator.</summary>
        public SwaggerJsonSchemaGenerator SchemaGenerator { get; set; }
    }
}

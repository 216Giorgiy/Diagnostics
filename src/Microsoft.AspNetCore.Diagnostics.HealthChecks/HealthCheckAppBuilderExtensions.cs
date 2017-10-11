// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Microsoft.AspNetCore.Builder
{
    public static class HealthCheckAppBuilderExtensions
    {
        /// <summary>
        /// Adds a middleware that provides a REST API for requesting health check status.
        /// </summary>
        /// <param name="applicationBuilder">The <see cref="IApplicationBuilder"/></param>
        /// <param name="path">The path on which to provide the API</param>
        /// <returns></returns>
        public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder applicationBuilder, PathString path)
        {
            applicationBuilder = applicationBuilder ?? throw new ArgumentNullException(nameof(applicationBuilder));

            return applicationBuilder.UseMiddleware<HealthCheckMiddleware>(new HealthCheckOptions()
            {
                Path = path
            });
        }
    }
}

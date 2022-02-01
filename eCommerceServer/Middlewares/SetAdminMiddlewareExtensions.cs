﻿namespace eCommerceServer.Middlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class SetAdminMiddlewareExtensions
    {
        public static IApplicationBuilder UseSetAdminMiddleware(
        this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SetAdminMiddleware>();
        }
    }
}
